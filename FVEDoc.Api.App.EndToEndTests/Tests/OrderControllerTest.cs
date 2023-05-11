using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Inverter;
using FVEDoc.Common.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class OrderControllerTest : TestBase<OrderModel, OrderModel>
{
    public OrderControllerTest()
        : base("order", BogusSeeder.SeedOrderModel())
    {

    }

}

