using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Order;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface IOrderFacade : IFacadeBase<OrderEntity, OrderModel>, IApiFacade
{
}

