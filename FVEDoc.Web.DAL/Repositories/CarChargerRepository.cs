using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.CarCharger;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class CarChargerRepository : RepositoryBase<CarChargerModel, CarChargerListModel>, IWebRepository
{
    public CarChargerRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<CarChargerRepository> logger)
        : base(httpClient, cache, config, logger, "car-charger")
    {

    }
}

