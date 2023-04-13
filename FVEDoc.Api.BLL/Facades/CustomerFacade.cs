using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Customer;

namespace FVEDoc.Api.BLL.Facades;
public class CustomerFacade : FacadeBase<CustomerEntity, CustomerModel>, ICustomerFacade
{
    public CustomerFacade(ICustomerRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

