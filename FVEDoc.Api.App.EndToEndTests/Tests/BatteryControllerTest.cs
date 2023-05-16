using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Battery;

namespace FVEDoc.Api.App.EndToEndTests.Tests;

public class BatteryControllerTest : TestBase<BatteryModel, BatteryListModel>
{
    public BatteryControllerTest()
        : base("battery", BogusSeeder.SeedBatteryModel())
    {

    }
}

