using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class InstallationTypeRepository : RepositoryBase<InstallationTypeEntity>, IInstallationTypeRepository
{
    public InstallationTypeRepository(MockDb bogus)
        :base(bogus.InstallationTypes)
    {
    }
}

