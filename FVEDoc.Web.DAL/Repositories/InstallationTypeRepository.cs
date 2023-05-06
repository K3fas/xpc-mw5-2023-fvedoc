using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class InstallationInfoRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public InstallationInfoRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<InstallationInfoRepository> logger)
        : base(httpClient, cache, config, logger, "installation-type")
    {

    }
}

