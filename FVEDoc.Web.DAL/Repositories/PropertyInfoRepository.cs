using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.PropertyInfo;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class PropertyInfoRepository : RepositoryBase<PropertyInfoModel, PropertyInfoListModel>, IWebRepository
{
    public PropertyInfoRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<PropertyInfoRepository> logger)
        : base(httpClient, cache, config, logger, "proprerty-info")
    {

    }
}

