using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.InstallationType;
using FVEDoc.Common.Models.Inverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class InverterControllerTest : TestBase<InverterModel, InverterModel>
{
    public InverterControllerTest()
        : base("inverter", BogusSeeder.SeedInverterModel())
    {

    }
}

