using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class PropertyInfoRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public PropertyInfoRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<PropertyInfoRepository> logger)
        : base(httpClient, cache, config, logger, "proprerty-info")
    {

    }
}

