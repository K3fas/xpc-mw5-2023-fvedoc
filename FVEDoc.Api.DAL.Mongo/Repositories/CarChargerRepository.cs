using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class CarChargerRepository : RepositoryBase<CarChargerEntity>, ICarChargerRepository
{
    public CarChargerRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<CarChargerEntity>("car-chargers"))
    {
    }
}

