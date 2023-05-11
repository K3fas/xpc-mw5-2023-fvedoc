using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class PVPanelRepository : RepositoryBase<PVPanelEntity>, IPVPanelRepository
{
    public PVPanelRepository(MockDb bogus)
        : base(bogus.PVPanels)
    {
    }
}

