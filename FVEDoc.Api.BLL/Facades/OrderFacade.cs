using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Order;

namespace FVEDoc.Api.BLL.Facades;
public class OrderFacade : FacadeBase<OrderEntity, OrderModel>, IOrderFacade
{
    public OrderFacade(IOrderRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

