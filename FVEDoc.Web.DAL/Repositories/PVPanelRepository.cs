using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.PVPanel;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class PVPanelRepository : RepositoryBase<PVPanelModel, PVPanelListModel>, IWebRepository
{
    public PVPanelRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<PVPanelRepository> logger)
        : base(httpClient, cache, config, logger, "pv-panel")
    {

    }
}

