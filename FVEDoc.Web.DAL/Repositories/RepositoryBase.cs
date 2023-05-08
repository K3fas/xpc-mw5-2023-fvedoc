using FVEDoc.Common.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace FVEDoc.Web.DAL.Repositories;
public class RepositoryBase<TDetailModel, TListModel>
    where TDetailModel : IModelBase
    where TListModel : IModelBase
{
    private readonly HttpClient _httpClient;
    private readonly IMemoryCache _cache;
    private readonly ILogger _logger;
    private readonly string _apiPath;


    public RepositoryBase(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger logger, string endpoint)
    {
        _apiPath = config["ApiPath"] ?? "";
        _apiPath += endpoint;
        _httpClient=httpClient;
        _cache=cache;
        _logger=logger;
    }



    public async Task<Guid> CreateAsync(TDetailModel model, CancellationToken c = default)
    {
        var response = await _httpClient.PostAsJsonAsync(_apiPath, model, c);
        response.EnsureSuccessStatusCode();

        ClearChache(nameof(TListModel));

        return model.Id;
    }

    public virtual async Task<List<TListModel>?> GetAllAsync(CancellationToken c = default)
    {
        if (_cache.TryGetValue(nameof(TListModel), out var output))
        {
            _logger.LogTrace("Getting {name} from cache", nameof(TListModel));

            var arr = output as TListModel[];

            return arr?.ToList();
        }

        _logger.LogTrace("Getting {name} from api", nameof(TListModel));

        var models = await _httpClient.GetFromJsonAsync<TListModel[]>(_apiPath, c);
        _cache.Set(nameof(TListModel), models, TimeSpan.FromMinutes(5));

        return models?.ToList();
    }

    public virtual async Task<TDetailModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        _logger.LogTrace("Getting {name} by {id}", nameof(TDetailModel), id);
        var response = await _httpClient.GetAsync($"{_apiPath}/{id}", c);
        response.EnsureSuccessStatusCode();

        var model = await response.Content.ReadFromJsonAsync<TDetailModel>(cancellationToken: c);

        return model;
    }

    public async Task<Guid> UpdateAsync(TDetailModel model, CancellationToken c = default)
    {
        _logger.LogTrace("Updating {name} by {id}", nameof(TDetailModel), model.Id);

        var response = await _httpClient.PutAsJsonAsync(_apiPath, model, c);
        response.EnsureSuccessStatusCode();

        ClearChache(nameof(TListModel));

        return model.Id;
    }

    public async Task<Guid> DeleteAsync(Guid id, CancellationToken c = default)
    {
        _logger.LogTrace("Deleting {name} by {id}", nameof(TDetailModel), id);

        var response = await _httpClient.DeleteAsync($"{_apiPath}/{id}", c);
        response.EnsureSuccessStatusCode();

        ClearChache(nameof(TListModel));

        return id;
    }

    public void ClearChache(string key)
    {
        _cache.Remove(key);
        _logger.LogTrace("Clearing chache: {key}", key);
    }
}

