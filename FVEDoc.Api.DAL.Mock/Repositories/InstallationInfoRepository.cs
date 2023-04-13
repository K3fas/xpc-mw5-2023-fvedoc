using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class InstallationInfoRepository : RepositoryBase<InstallationInfoEntity>, IInstallationInfoRepository
{
    public InstallationInfoRepository(MockDb bogus)
        :base(bogus.InstallationInfos)
    {
    }
}

