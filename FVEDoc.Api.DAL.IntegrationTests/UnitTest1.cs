
using FVEDoc.Api.DAL.Mongo;

namespace FVEDoc.Api.DAL.IntegrationTests;

public class TestBase
{
    public MongoDbContext _dbContext;
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}