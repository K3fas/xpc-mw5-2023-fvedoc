using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.Customer;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class CustomerRepository : RepositoryBase<CustomerModel, CustomerListModel>, IWebRepository
{
    public CustomerRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<CustomerRepository> logger)
        : base(httpClient, cache, config, logger, "customers")
    {

    }
}

