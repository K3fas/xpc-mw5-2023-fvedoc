using FVEDoc.Common.Models.Battery;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class CustomerRepository : RepositoryBase<BatteryModel, BatteryListModel>
{
    public CustomerRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, Logger<CustomerRepository> logger)
        : base(httpClient, cache, config, logger, "customers")
    {

    }
}

