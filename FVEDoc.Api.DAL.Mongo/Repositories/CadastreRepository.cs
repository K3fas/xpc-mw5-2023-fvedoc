using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class CadastreRepository : RepositoryBase<CadastreDataEntity>, ICadastreRepository
{
    public CadastreRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<CadastreDataEntity>("cadastre-data"))
    {
    }
}

