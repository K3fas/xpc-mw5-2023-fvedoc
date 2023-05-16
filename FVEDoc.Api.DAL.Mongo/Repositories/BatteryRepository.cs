using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class BatteryRepository : RepositoryBase<BatteryEntity>, IBatteryRepository
{
    public BatteryRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<BatteryEntity>("batteries"))
    {
    }
}

