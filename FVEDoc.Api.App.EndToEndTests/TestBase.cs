
using Bogus;
using FVEDoc.Api.DAL.Mongo.Serializers;
using FVEDoc.Common.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using NUnit.Framework;
using System.Net;
using System.Net.Http.Json;

namespace FVEDoc.Api.App.EndToEndTests;
[TestFixture]
[Ignore("BaseClass")]
public class TestBase<TDetailModel, TListModel> : IAsyncDisposable
    where TDetailModel : class, IModelBase
    where TListModel : IModelBase
{

    private readonly FVEDocApplicationFactory _app;
    private readonly Lazy<HttpClient> _client;
    private readonly string _route;
    private readonly Faker<TDetailModel> _seeder;

    public TestBase(string route, Faker<TDetailModel> seeder)
    {
        _app = new FVEDocApplicationFactory();
        _client = new Lazy<HttpClient>(_app.CreateClient());
        _route=route;
        _seeder=seeder;
    }

    [Test]
    public async Task Create_EnsureSuccess_AllreadyExists_BadFormat()
    {
        var model = _seeder.Generate();
        var response = await _client.Value.PostAsJsonAsync(_route, model);

        Assert.True(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        Assert.True(response.Headers.Location?.ToString() == "/"+model.Id);

        response = await _client.Value.PostAsJsonAsync(_route, model);
        Assert.False(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);

        response = await _client.Value.DeleteAsync(_route+$"/{model.Id}");
        Assert.True(response.IsSuccessStatusCode);

    }

    [Test]
    public async Task Get_EnsureSuccess()
    {
        var response = await _client.Value.GetAsync(_route);

        Assert.True(response.IsSuccessStatusCode);
    }

    [Test]
    public async Task GetById_EnsureSuccess_NotFound()
    {
        var model = _seeder.Generate();
        var response = await _client.Value.PostAsJsonAsync(_route, model);

        Assert.True(response.IsSuccessStatusCode);

        response = await _client.Value.GetAsync(_route+$"/{model.Id}");
        var retModel = await response.Content.ReadFromJsonAsync<TDetailModel>();

        Assert.True(response.IsSuccessStatusCode);
        Assert.NotNull(retModel);
        Assert.AreEqual(retModel.Id, model.Id);

        response = await _client.Value.GetAsync(_route+$"/{Guid.NewGuid()}");
        Assert.False(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);

        response = await _client.Value.DeleteAsync(_route+$"/{model.Id}");
        Assert.True(response.IsSuccessStatusCode);
    }

    [Test]
    public async Task Put_EnsureSuccess_BadFormat()
    {
        var model = _seeder.Generate();
        var response = await _client.Value.PutAsJsonAsync(_route, model);

        Assert.True(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        Assert.AreEqual(response.Headers.Location?.ToString(), "/"+model.Id);

        response = await _client.Value.PutAsJsonAsync(_route, model);
        Assert.True(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        await _client.Value.DeleteAsync(_route+$"/{model.Id}");
        Assert.True(response.IsSuccessStatusCode);

    }

    [Test]
    public async Task Delete_EnsureSuccess_NotFound()
    {
        var model = _seeder.Generate();
        var response = await _client.Value.PostAsJsonAsync(_route, model);

        Assert.True(response.IsSuccessStatusCode);

        response = await _client.Value.DeleteAsync(_route+$"/{model.Id}");
        Assert.True(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        response = await _client.Value.DeleteAsync(_route+$"/{model.Id}");
        Assert.False(response.IsSuccessStatusCode);
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
    }

    public async ValueTask DisposeAsync()
    {
        await _app.DisposeAsync();
    }
}

