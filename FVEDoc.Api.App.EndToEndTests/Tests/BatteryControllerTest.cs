using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;

public class BatteryControllerTest : TestBase<BatteryModel, BatteryListModel>
{
    public BatteryControllerTest()
        :base("battery", BogusSeeder.SeedBatteryModel())
    {

    }
}

