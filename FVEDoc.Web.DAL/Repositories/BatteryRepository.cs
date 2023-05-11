using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace FVEDoc.Web.DAL.Repositories;
public class BatteryRepository : RepositoryBase<BatteryModel, BatteryListModel>, IWebRepository
{
    public BatteryRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<BatteryRepository> logger)
        :base(httpClient, cache, config, logger, "battery")
    {

    }
}

