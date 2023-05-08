using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.InstallationInfo;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class InstallationTypeRepository : RepositoryBase<InstallationInfoModel, InstallationInfoListModel>, IWebRepository
{
    public InstallationTypeRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<InstallationTypeRepository> logger)
        : base(httpClient, cache, config, logger, "installation-info")
    {

    }
}

