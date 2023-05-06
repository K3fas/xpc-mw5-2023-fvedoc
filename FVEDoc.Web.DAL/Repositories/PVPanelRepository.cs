using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class PVPanelRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public PVPanelRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<BatteryRepository> logger, string apiPath)
        : base(httpClient, cache, config, logger, apiPath)
    {

    }
}

