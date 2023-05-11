using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
{
    public OrderRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<OrderEntity>("orders"))
    {
    }
}

