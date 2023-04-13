using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class InstallationInfoRepository : RepositoryBase<InstallationInfoEntity>, IInstallationInfoRepository
{
    public InstallationInfoRepository(BogusSeeder bogus)
        :base(bogus.InstallationInfos)
    {
    }
}

