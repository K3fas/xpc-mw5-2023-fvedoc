using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class CustomerRepository : RepositoryBase<CustomerEntity>, ICustomerRepository
{
    public CustomerRepository(MongoDbContext mongo)
        : base(mongo.GetCollection<CustomerEntity>("customers"))
    {
    }
}

