using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Inverter;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class InverterControllerTest : TestBase<InverterModel, InverterModel>
{
    public InverterControllerTest()
        : base("inverter", BogusSeeder.SeedInverterModel())
    {

    }
}

