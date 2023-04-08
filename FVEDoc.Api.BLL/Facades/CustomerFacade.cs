using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Customer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades;
public class CustomerFacade : FacadeBase<CustomerEntity, CustomerModel>, ICustomerFacade
{
    public CustomerFacade(ICustomerRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

