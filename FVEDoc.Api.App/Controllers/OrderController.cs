using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Order;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("order")]
public class OrderController : BasicController<OrderEntity, OrderModel>
{
    public OrderController(ILogger<OrderController> logger, IOrderFacade facade)
        : base(logger, facade)
    {
    }
}
