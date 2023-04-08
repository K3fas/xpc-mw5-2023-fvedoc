using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades;
public class OrderFacade : FacadeBase<OrderEntity, OrderModel>
{
    public OrderFacade(IOrderRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

