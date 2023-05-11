using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.CarCharger;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class CarChargerControllerTest : TestBase<CarChargerModel, CarChargerModel>
{
    public CarChargerControllerTest()
        : base("car-charger", BogusSeeder.SeedCarChargerModel())
    {

    }
}

