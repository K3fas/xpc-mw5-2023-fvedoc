using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class PVPanelRepository : RepositoryBase<PVPanelEntity>, IPVPanelRepository
{
    public PVPanelRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<PVPanelEntity>("PV-panels"))
    {
    }
}

