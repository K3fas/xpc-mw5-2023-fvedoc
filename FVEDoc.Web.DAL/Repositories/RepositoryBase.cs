using FVEDoc.Common.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace FVEDoc.Web.DAL.Repositories;
public class RepositoryBase<TDetailModel, TListModel> : IWebRepository<TDetailModel, TListModel>
    where TDetailModel : IModelBase
    where TListModel : IModelBase
{
    private readonly HttpClient _httpClient;
    private readonly string _apiPathBase = "https://localhost:5002";
    private readonly string _apiPath;

    public RepositoryBase(HttpClient httpClient, string apiPath)
    {
        _httpClient=httpClient;
        _apiPath=apiPath;
    }

    public virtual async Task<List<TListModel>?> GetAllAsync(CancellationToken c = default)
    {
        try
        {
            var models = await _httpClient.GetFromJsonAsync<TListModel[]>(_apiPathBase + _apiPath, c);
            return models.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public virtual async Task<TDetailModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        var response = await _httpClient.GetAsync($"{_apiPath}/{{{id}}}", c);
        response.EnsureSuccessStatusCode();

        var stream = await response.Content.ReadAsStreamAsync(c);
        var model = JsonSerializer.Deserialize<TDetailModel>(stream);

        return model;
    }
}

