using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class OrderRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public OrderRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<BatteryRepository> logger)
        : base(httpClient, cache, config, logger, "order")
    {

    }
}

