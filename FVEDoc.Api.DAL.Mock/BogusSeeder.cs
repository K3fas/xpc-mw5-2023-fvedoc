using Bogus;
using FVEDoc.Api.DAL.Common.Entities;

namespace FVEDoc.Api.DAL.Mock;
public static class BogusSeeder
{
    private static readonly List<string> _places = new() { "Basement", "Hallway", "Technical room" };
    public static void SeedData(MockDb db)
    {
        SeedBatteries(db);
        SeedCadastreData(db);
        SeedCarChargers(db);
        SeedCustomers(db);
        SeedInverters(db);
        SeedPropertyInfo(db);
        SeedPVPanels(db);
        SeeInstallationTypes(db);
        SeedInstalaltionInfos(db);
        SeedOrers(db);
    }

    static private void SeedBatteries(MockDb db)
    {
        var faker = new Faker<BatteryEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.BlockCapacity, x => x.Random.Double(0, 20))
            .RuleFor(x => x.BlockCount, x => x.Random.Int(0, 5))
            .RuleFor(x => x.BlockTechnology, x => x.Name.JobTitle())
            .RuleFor(x => x.ContinuousCharge, x => x.Random.Double(0, 10))
            .RuleFor(x => x.ContinuousDischarge, x => x.Random.Double(0, 10))
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.LifeExpectacy, x => x.Random.Double(4000, 6000)+" cycles")
            .RuleFor(x => x.Name, x => x.Name.FirstName())
            .RuleFor(x => x.TotalCapacity, x => x.Random.Double(5, 15))
            .RuleFor(x => x.Weigth, x => x.Random.Double(40, 80));


        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.Batteries.Add(item);
        }

    }

    static private void SeedCadastreData(MockDb db)
    {
        var faker = new Faker<CadastreDataEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.CadastreID, x => x.Address.City() + x.Random.UInt(1000, 9999))
            .RuleFor(x => x.CityID, x => x.Address.City() + x.Random.UInt(1000, 9999))
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.ParcelNumber, x => "st. " + x.Random.Int(0, 99999))
            .RuleFor(x => x.PLNumber, x => x.Random.Int(0, 99999));


        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.CadastreData.Add(item);
        }
    }

    static private void SeedCarChargers(MockDb db)
    {
        var faker = new Faker<CarChargerEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.Name, x => x.Commerce.Product())
            .RuleFor(x => x.Power, x => x.Random.Double(3, 10));


        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.CarChargers.Add(item);
        }

    }

    static private void SeedCustomers(MockDb db)
    {
        var faker = new Faker<CustomerEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.City, x => x.Address.City())
            .RuleFor(x => x.CompanyID, x => "IC" + x.Random.UInt(0, 9999999))
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.Name, x => x.Name.FullName())
            .RuleFor(x => x.Street, x => x.Address.StreetAddress())
            .RuleFor(x => x.ZIP, x => x.Address.ZipCode());

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.Customers.Add(item);
        }

    }

    static private void SeedInstalaltionInfos(MockDb db)
    {
        var faker = new Faker<InstallationInfoEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.CYADiameter, x => x.Random.Int(8, 16))
            .RuleFor(x => x.InstallationType, x => x.PickRandom(db.InstallationTypes))
            .RuleFor(x => x.PVStrings, x => x.Random.ListItems(new List<int> { 8, 9, 10, 11, 12, 13, 14 }, 2))
            .RuleFor(x => x.SolarCable, x => "EUCASOLAR")
            .RuleFor(x => x.TechnologyPlace, x => x.PickRandom(_places));

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.InstallationInfos.Add(item);
        }

    }

    static private void SeeInstallationTypes(MockDb db)
    {
        var faker = new Faker<InstallationTypeEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.Battery, x => x.PickRandom(db.Batteries))
            .RuleFor(x => x.CarCharger, x => x.PickRandom(db.CarChargers))
            .RuleFor(x => x.Inverter, x => x.PickRandom(db.Inverters))
            .RuleFor(x => x.Power, x => x.Random.Double(6, 9.99))
            .RuleFor(x => x.PVPanel, x => x.PickRandom(db.PVPanels))
            .RuleFor(x => x.PVPanelCount, x => x.Random.Int(16, 24))
            .RuleFor(x => x.PVTypeID, x => x.Random.ListItem(new List<string> { "Aa1", "B", "C1", "Ca1" }));

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.InstallationTypes.Add(item);
        }

    }

    private static void SeedInverters(MockDb db)
    {
        var faker = new Faker<InverterEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.Efficiency, x => x.Random.Double(95, 98))
            .RuleFor(x => x.IPCover, x => 65)
            .RuleFor(x => x.MaxACPower, x => x.Random.Double(8, 12))
            .RuleFor(x => x.MaxDCPower, x => x.Random.Double(10, 14))
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.NominalACVoltage, x => x.Random.ListItem(new List<double> { 800, 1000, 1200 }))
            .RuleFor(x => x.SVT, x => x.Random.Int(0, 99999));

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.Inverters.Add(item);
        }
    }

    private static void SeedOrers(MockDb db)
    {
        var faker = new Faker<OrderEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.InstallationType, x => x.PickRandom(db.InstallationTypes))
            .RuleFor(x => x.OrderId, x => x.Random.Int(0, 900));

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.Orders.Add(item);
        }

    }

    private static void SeedPropertyInfo(MockDb db)
    {
        var faker = new Faker<PropertyInfoEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.CadastreData, x => x.PickRandom(db.CadastreData))
            .RuleFor(x => x.MainCB, x => x.PickRandom(new List<int> { 25, 30, 35, 40 }))
            .RuleFor(x => x.MainCBPlace, x => x.PickRandom(_places))
            .RuleFor(x => x.MainHeating, x => x.PickRandom(new List<string> { "Electric boiler", "Solid fuels", "Gas boiler", "Heat pump" }))
            .RuleFor(x => x.OccupantsCount, x => x.Random.Int(2, 5))
            .RuleFor(x => x.WaterHeating, x => x.PickRandom(new List<string> { "Electric boiler", "Solid fuels", "Gas boiler", "Heat pump" }));

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.PropertyInfos.Add(item);
        }
    }

    private static void SeedPVPanels(MockDb db)
    {
        var faker = new Faker<PVPanelEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.Efficiency, x => x.Random.Double(25, 29))
            .RuleFor(x => x.MaxPowerCurrent, x => x.Random.Double(10, 15))
            .RuleFor(x => x.MaxPowerVoltage, x => x.Random.Double(40, 50))
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.NLVoltage, x => x.Random.Double(50, 60))
            .RuleFor(x => x.Power, x => x.PickRandom(new List<double> { 380, 400, 450, 420 }))
            .RuleFor(x => x.SCCurrent, x => x.Random.Double(15, 18))
            .RuleFor(x => x.SVT, x => x.Random.Int(0, 99999))
            .RuleFor(x => x.Weight, x => x.Random.Double(20, 25));

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            db.PVPanels.Add(item);
        }


    }
}

