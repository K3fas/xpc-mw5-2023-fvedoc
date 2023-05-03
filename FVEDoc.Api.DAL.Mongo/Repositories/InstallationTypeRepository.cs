using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class InstallationTypeRepository : RepositoryBase<InstallationTypeEntity>, IInstallationTypeRepository
{
    public InstallationTypeRepository(MongoDbContext mongo)
        :base(mongo.GetCollection<InstallationTypeEntity>("installation-types"))
    {
    }
}

