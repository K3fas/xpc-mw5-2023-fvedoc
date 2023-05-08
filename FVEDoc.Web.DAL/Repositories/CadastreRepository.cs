using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.CadastreData;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class CadastreRepository : RepositoryBase<CadastreDataModel, CadastreDataListModel>, IWebRepository
{
    public CadastreRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<CadastreRepository> logger)
        : base(httpClient, cache, config, logger, "cadastre")
    {

    }
}

