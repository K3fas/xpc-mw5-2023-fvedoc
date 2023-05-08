using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.Inverter;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class InverterRepository : RepositoryBase<InverterModel, InverterListModel>, IWebRepository
{
    public InverterRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<InverterRepository> logger)
        : base(httpClient, cache, config, logger, "inverter")
    {

    }
}

