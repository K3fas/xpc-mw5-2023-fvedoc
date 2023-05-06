using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class InstallationTypeRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public InstallationTypeRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<InstallationTypeRepository> logger)
        : base(httpClient, cache, config, logger, "installation-info")
    {

    }
}

