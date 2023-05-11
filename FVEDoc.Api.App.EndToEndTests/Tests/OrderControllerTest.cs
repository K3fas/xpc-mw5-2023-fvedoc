using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Order;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class OrderControllerTest : TestBase<OrderModel, OrderModel>
{
    public OrderControllerTest()
        : base("order", BogusSeeder.SeedOrderModel())
    {

    }

}

