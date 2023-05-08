using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.Order;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Web.BLL.Facades;
public class OrderFacade : FacadeBase<OrderModel, OrderListModel>, IWebFacade
{
    public OrderFacade(OrderRepository repo, ILogger<BatteryFacade> logger)
        : base(repo, logger)
    {
    }
}

