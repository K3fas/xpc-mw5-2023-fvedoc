using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class CustomerRepository : RepositoryBase<CustomerEntity>, ICustomerRepository
{
    public CustomerRepository(BogusSeeder bogus)
        :base(bogus.Customers)
    {
    }
}

