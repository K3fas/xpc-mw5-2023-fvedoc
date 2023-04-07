using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class CustomerRepository : RepositoryBase<CustomerEntity>
{
    public CustomerRepository(Bogus bogus)
        :base(bogus.Customers)
    {
    }
}

