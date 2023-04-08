using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;

using FVEDoc.Common.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomerController : BasicController<CustomerEntity, CustomerModel>
{
    public CustomerController(ILogger<CustomerController> logger, ICustomerFacade facade)
        : base(logger, facade)
    {
    }
}
