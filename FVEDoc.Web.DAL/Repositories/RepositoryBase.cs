using FVEDoc.Common.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;
using System.Reflection;
using System.Text.Json;

namespace FVEDoc.Web.DAL.Repositories;
public class RepositoryBase<TDetailModel, TListModel> : IWebRepository
    where TDetailModel : IModelBase
    where TListModel : IModelBase
{
    private readonly HttpClient _httpClient;
    private readonly IMemoryCache _cache;
    private readonly ILogger _logger;
    private readonly string _apiPath;
    private readonly string _endpoint;


    public RepositoryBase(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger logger, string endpoint)
    {
        _apiPath = config["ApiPath"] ?? "";
        _endpoint=endpoint;
        _httpClient=httpClient;
        _cache=cache;
        _logger=logger;
    }



    public async Task<Guid> CreateAsync(TDetailModel model, CancellationToken c = default)
    {
        var response = await _httpClient.PostAsJsonAsync(_apiPath + _endpoint, model, c);
        response.EnsureSuccessStatusCode();

        ClearChache(nameof(TListModel));

        return model.Id;
    }

    public virtual async Task<List<TListModel>?> GetAllAsync(CancellationToken c = default)
    {
        if(_cache.TryGetValue(nameof(TListModel), out var output))
        {
            var arr = output as TListModel[];

            _logger.LogTrace("Getting {name} from cache", nameof(TListModel));

            return arr?.ToList();
        }
        try
        {
            var models = await _httpClient.GetFromJsonAsync<TListModel[]>(_apiPath + _endpoint, c);
            _cache.Set(nameof(TListModel), models, TimeSpan.FromMinutes(5));

            _logger.LogTrace("Getting {name} from api", nameof(TListModel));

            return models?.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public virtual async Task<TDetailModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        var response = await _httpClient.GetAsync($"{_endpoint}/{{{id}}}", c);
        response.EnsureSuccessStatusCode();

        var stream = await response.Content.ReadAsStreamAsync(c);
        var model = JsonSerializer.Deserialize<TDetailModel>(stream);

        _logger.LogTrace("Getting {name} by {id}", nameof(TDetailModel), id);

        return model;
    }

    public async Task<Guid> UpdateAsync(TDetailModel model, CancellationToken c = default)
    {
        var response = await _httpClient.PutAsJsonAsync(_apiPath + _endpoint, model, c);
        response.EnsureSuccessStatusCode();

        _logger.LogTrace("Updating {name} by {id}", nameof(TDetailModel), model.Id);

        ClearChache(nameof(TListModel));

        return model.Id;
    }

    public async Task<Guid> DeleteAsync(Guid id, CancellationToken c = default)
    {
        var response = await _httpClient.DeleteAsync($"{_apiPath + _endpoint}/{{{id}}}");
        response.EnsureSuccessStatusCode();

        _logger.LogTrace("Deleting {name} by {id}", nameof(TDetailModel), id);

        ClearChache(nameof(TListModel));

        return id;
    }

    public void ClearChache(string key)
    {
        _cache.Remove(key);
        _logger.LogTrace("Clearing chache: {key}", key);
    }
}

