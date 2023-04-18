using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class InverterRepository : RepositoryBase<InverterEntity>, IInverterRepository
{
    public InverterRepository(MongoDbContext mongo)
        :base(mongo.GetCollection<InverterEntity>("inverters"))
    {
    }
}

