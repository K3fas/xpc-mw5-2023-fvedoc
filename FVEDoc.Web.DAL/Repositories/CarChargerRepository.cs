using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class CarChargerRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public CarChargerRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<CarChargerRepository> logger)
        : base(httpClient, cache, config, logger, "car-charger")
    {

    }
}

