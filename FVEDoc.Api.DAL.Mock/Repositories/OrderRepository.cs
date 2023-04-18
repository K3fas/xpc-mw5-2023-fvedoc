using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
{
    public OrderRepository(MockDb bogus)
        :base(bogus.Orders)
    {
    }
}

