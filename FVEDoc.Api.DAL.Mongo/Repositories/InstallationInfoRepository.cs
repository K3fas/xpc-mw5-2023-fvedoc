using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class InstallationInfoRepository : RepositoryBase<InstallationInfoEntity>, IInstallationInfoRepository
{


    public InstallationInfoRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<InstallationInfoEntity>("installation-info"))
    {

    }

    public override Task<InstallationInfoEntity?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        return base.GetByIdAsync(id, c);
    }

}

