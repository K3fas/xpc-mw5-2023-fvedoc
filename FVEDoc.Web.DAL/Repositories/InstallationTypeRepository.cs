﻿using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.InstallationType;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class InstallationInfoRepository : RepositoryBase<InstallationTypeModel, InstallationTypeListModel>, IWebRepository
{
    public InstallationInfoRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<InstallationInfoRepository> logger)
        : base(httpClient, cache, config, logger, "installation-type")
    {

    }
}

