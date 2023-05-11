using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.Order;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.DAL.Repositories;
public class OrderRepository : RepositoryBase<OrderModel, OrderListModel>, IWebRepository
{
    public OrderRepository(HttpClient httpClient, IMemoryCache cache, IConfiguration config, ILogger<OrderRepository> logger)
        : base(httpClient, cache, config, logger, "order")
    {

    }
}

