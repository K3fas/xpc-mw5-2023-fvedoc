using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Customer;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface ICustomerFacade : IFacadeBase<CustomerEntity, CustomerModel>, IApiFacade
{
}

