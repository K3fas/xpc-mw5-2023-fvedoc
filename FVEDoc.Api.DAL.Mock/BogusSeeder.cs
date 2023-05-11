using Bogus;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.CadastreData;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.Customer;
using FVEDoc.Common.Models.InstallationInfo;
using FVEDoc.Common.Models.InstallationType;
using FVEDoc.Common.Models.Inverter;
using FVEDoc.Common.Models.Order;
using FVEDoc.Common.Models.PropertyInfo;
using FVEDoc.Common.Models.PVPanel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FVEDoc.Api.DAL.Mock;
public static class BogusSeeder
{
    private static readonly List<string> _places = new() { "Basement", "Hallway", "Technical room" };
    private static MockDb _db;
    public static void SeedData(MockDb db)
    {
        _db = db;
        SeedBatteries(db.Batteries);
        SeedCadastreData(db.CadastreData);
        SeedCarChargers(db.CarChargers);
        SeedCustomers(db.Customers);
        SeedInverters(db.Inverters);
        SeedPropertyInfos(db.PropertyInfos);
        SeedPVPanels(db.PVPanels);
        SeeInstallationTypes(db.InstallationTypes);
        SeedInstalaltionInfos(db.InstallationInfos);
        SeedOrers(db.Orders);
    }

    static private void SeedBatteries(IList<BatteryEntity> list)
    {
        Faker<BatteryEntity> faker = SeedBattery();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }

    }

    public static Faker<BatteryEntity> SeedBattery()
    {
        return new Faker<BatteryEntity>()
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
    }

    public static Faker<BatteryModel> SeedBatteryModel()
    {
        return new Faker<BatteryModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.BlockCapacity, x => x.Random.Double(0, 20))
            .RuleFor(x => x.BlockCount, x => x.Random.Int(0, 5))
            .RuleFor(x => x.BlockTechnology, x => x.Name.JobTitle())
            .RuleFor(x => x.ContinuousCharge, x => x.Random.Double(0, 10))
            .RuleFor(x => x.ContinuousDischarge, x => x.Random.Double(0, 10))
            .RuleFor(x => x.LifeExpectacy, x => x.Random.Double(4000, 6000)+" cycles")
            .RuleFor(x => x.Name, x => x.Name.FirstName())
            .RuleFor(x => x.TotalCapacity, x => x.Random.Double(5, 15))
            .RuleFor(x => x.Weigth, x => x.Random.Double(40, 80));
    }

    static private void SeedCadastreData(IList<CadastreDataEntity> list)
    {
        Faker<CadastreDataEntity> faker = SeedCadastreData();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }
    }

    public static Faker<CadastreDataEntity> SeedCadastreData()
    {
        return new Faker<CadastreDataEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.CadastreID, x => x.Address.City() + x.Random.UInt(1000, 9999))
            .RuleFor(x => x.CityID, x => x.Address.City() + x.Random.UInt(1000, 9999))
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.ParcelNumber, x => "st. " + x.Random.Int(0, 99999))
            .RuleFor(x => x.PLNumber, x => x.Random.Int(0, 99999));
    }

    public static Faker<CadastreDataModel> SeedCadastreDataModel()
    {
        return new Faker<CadastreDataModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.CadastreID, x => x.Address.City() + x.Random.UInt(1000, 9999))
            .RuleFor(x => x.CityID, x => x.Address.City() + x.Random.UInt(1000, 9999))
            .RuleFor(x => x.ParcelNumber, x => "st. " + x.Random.Int(0, 99999))
            .RuleFor(x => x.PLNumber, x => x.Random.Int(0, 99999));
    }

    static private void SeedCarChargers(IList<CarChargerEntity> list)
    {
        Faker<CarChargerEntity> faker = SeedCarCharger();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }

    }

    public static Faker<CarChargerEntity> SeedCarCharger()
    {
        return new Faker<CarChargerEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.Name, x => x.Commerce.Product())
            .RuleFor(x => x.Power, x => x.Random.Double(3, 10));
    }

    public static Faker<CarChargerModel> SeedCarChargerModel()
    {
        return new Faker<CarChargerModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.Name, x => x.Commerce.Product())
            .RuleFor(x => x.Power, x => x.Random.Double(3, 10));
    }

    static private void SeedCustomers(IList<CustomerEntity> list)
    {
        Faker<CustomerEntity> faker = SeedCustomer();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }

    }

    public static Faker<CustomerEntity> SeedCustomer()
    {
        return new Faker<CustomerEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.City, x => x.Address.City())
            .RuleFor(x => x.CompanyID, x => "IC" + x.Random.UInt(0, 9999999))
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.Name, x => x.Name.FullName())
            .RuleFor(x => x.Street, x => x.Address.StreetAddress())
            .RuleFor(x => x.ZIP, x => x.Address.ZipCode());
    }

    public static Faker<CustomerModel> SeedCustomerModel()
    {
        return new Faker<CustomerModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.City, x => x.Address.City())
            .RuleFor(x => x.CompanyID, x => "IC" + x.Random.UInt(0, 9999999))
            .RuleFor(x => x.Name, x => x.Name.FullName())
            .RuleFor(x => x.Street, x => x.Address.StreetAddress())
            .RuleFor(x => x.ZIP, x => x.Address.ZipCode());
    }

    static private void SeedInstalaltionInfos(IList<InstallationInfoEntity> list)
    {
        Faker<InstallationInfoEntity> faker = SeedInstallationInfo();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }

    }

    public static Faker<InstallationInfoEntity> SeedInstallationInfo()
    {
        return new Faker<InstallationInfoEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.CYADiameter, x => x.Random.Int(8, 16))
            .RuleFor(x => x.InstallationType, x => x.PickRandom( _db.InstallationTypes.Select(x => x.Id)))
            .RuleFor(x => x.PVStrings, x => x.Random.ListItems(new List<int> { 8, 9, 10, 11, 12, 13, 14 }, 2))
            .RuleFor(x => x.SolarCable, x => "EUCASOLAR")
            .RuleFor(x => x.TechnologyPlace, x => x.PickRandom(_places));
    }

    public static Faker<InstallationInfoModel> SeedInstallationInfoModel()
    {
        return new Faker<InstallationInfoModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.InstallationType, x => SeedInstallationTypeModel().Generate())
            .RuleFor(x => x.CYADiameter, x => x.Random.Int(8, 16))
            .RuleFor(x => x.PVStrings, x => x.Random.ListItems(new List<int> { 8, 9, 10, 11, 12, 13, 14 }, 2))
            .RuleFor(x => x.SolarCable, x => "EUCASOLAR")
            .RuleFor(x => x.TechnologyPlace, x => x.PickRandom(_places));
    }

    static private void SeeInstallationTypes(IList<InstallationTypeEntity> list)
    {
        Faker<InstallationTypeEntity> faker = SeedInstallationType();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }

    }

    public static Faker<InstallationTypeEntity> SeedInstallationType()
    {
        return new Faker<InstallationTypeEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.Battery, x => x.PickRandom(_db.Batteries.Select(x => x.Id)))
            .RuleFor(x => x.CarCharger, x => x.PickRandom(_db.CarChargers.Select(x => x.Id)))
            .RuleFor(x => x.Inverter, x => x.PickRandom(_db.Inverters.Select(x => x.Id)))
            .RuleFor(x => x.Power, x => x.Random.Double(6, 9.99))
            .RuleFor(x => x.PVPanel, x => x.PickRandom(_db.PVPanels.Select(x => x.Id)))
            .RuleFor(x => x.PVPanelCount, x => x.Random.Int(16, 24))
            .RuleFor(x => x.PVTypeID, x => x.Random.ListItem(new List<string> { "Aa1", "B", "C1", "Ca1" }));
    }

    public static Faker<InstallationTypeModel> SeedInstallationTypeModel()
    {
        return new Faker<InstallationTypeModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.Battery, x => x.PickRandom(SeedBatteryModel().Generate()))
            .RuleFor(x => x.CarCharger, x => x.PickRandom(SeedCarChargerModel().Generate()))
            .RuleFor(x => x.Inverter, x => x.PickRandom(SeedInverterModel().Generate()))
            .RuleFor(x => x.Power, x => x.Random.Double(6, 9.99))
            .RuleFor(x => x.PVPanel, x => x.PickRandom(SeedPVPanelModel().Generate()))
            .RuleFor(x => x.PVPanelCount, x => x.Random.Int(16, 24))
            .RuleFor(x => x.PVTypeID, x => x.Random.ListItem(new List<string> { "Aa1", "B", "C1", "Ca1" }));
    }

    private static void SeedInverters(IList<InverterEntity> list)
    {
        Faker<InverterEntity> faker = SeedInverter();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }
    }

    public static Faker<InverterEntity> SeedInverter()
    {
        return new Faker<InverterEntity>()
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
    }

    public static Faker<InverterModel> SeedInverterModel()
    {
        return new Faker<InverterModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.Efficiency, x => x.Random.Double(95, 98))
            .RuleFor(x => x.IPCover, x => 65)
            .RuleFor(x => x.MaxACPower, x => x.Random.Double(8, 12))
            .RuleFor(x => x.MaxDCPower, x => x.Random.Double(10, 14))
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.NominalACVoltage, x => x.Random.ListItem(new List<double> { 800, 1000, 1200 }))
            .RuleFor(x => x.SVT, x => x.Random.Int(0, 99999));
    }

    private static void SeedOrers(IList<OrderEntity> list)
    {
        Faker<OrderEntity> faker = SeedOrder();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }

    }

    public static Faker<OrderEntity> SeedOrder()
    {
        return new Faker<OrderEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.InstallationType, x => x.PickRandom(_db.InstallationTypes.Select(x => x.Id)))
            .RuleFor(x => x.OrderId, x => x.Random.Int(0, 900));
    }

    public static Faker<OrderModel> SeedOrderModel()
    {
        return new Faker<OrderModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.InstallationType, x => x.PickRandom(SeedInstallationTypeModel().Generate()))
            .RuleFor(x => x.OrderId, x => x.Random.Int(0, 900));
    }

    private static void SeedPropertyInfos(IList<PropertyInfoEntity> list)
    {
        Faker<PropertyInfoEntity> faker = SeedPropertyInfo();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }
    }

    public static Faker<PropertyInfoEntity> SeedPropertyInfo()
    {
        return new Faker<PropertyInfoEntity>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.DateModified, x => x.Date.Recent())
            .RuleFor(x => x.DateCreated, x => x.Date.Recent())
            .RuleFor(x => x.CadastreData, x => x.PickRandom(_db.CadastreData.Select(x => x.Id)))
            .RuleFor(x => x.MainCB, x => x.PickRandom(new List<int> { 25, 30, 35, 40 }))
            .RuleFor(x => x.MainCBPlace, x => x.PickRandom(_places))
            .RuleFor(x => x.MainHeating, x => x.PickRandom(new List<string> { "Electric boiler", "Solid fuels", "Gas boiler", "Heat pump" }))
            .RuleFor(x => x.OccupantsCount, x => x.Random.Int(2, 5))
            .RuleFor(x => x.WaterHeating, x => x.PickRandom(new List<string> { "Electric boiler", "Solid fuels", "Gas boiler", "Heat pump" }));
    }

    public static Faker<PropertyInfoModel> SeedPropertyInfoModel()
    {
        return new Faker<PropertyInfoModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.MainCB, x => x.PickRandom(new List<int> { 25, 30, 35, 40 }))
            .RuleFor(x => x.MainCBPlace, x => x.PickRandom(_places))
            .RuleFor(x => x.MainHeating, x => x.PickRandom(new List<string> { "Electric boiler", "Solid fuels", "Gas boiler", "Heat pump" }))
            .RuleFor(x => x.OccupantsCount, x => x.Random.Int(2, 5))
            .RuleFor(x => x.WaterHeating, x => x.PickRandom(new List<string> { "Electric boiler", "Solid fuels", "Gas boiler", "Heat pump" }));
    }

    private static void SeedPVPanels(IList<PVPanelEntity> list)
    {
        Faker<PVPanelEntity> faker = SeedPVPanel();

        var fakes = faker.GenerateBetween(10, 20);
        foreach (var item in fakes)
        {
            list.Add(item);
        }


    }

    public static Faker<PVPanelEntity> SeedPVPanel()
    {
        return new Faker<PVPanelEntity>()
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
    }

    public static Faker<PVPanelModel> SeedPVPanelModel()
    {
        return new Faker<PVPanelModel>()
            .RuleFor(x => x.Id, x => x.Random.Guid())
            .RuleFor(x => x.Efficiency, x => x.Random.Double(25, 29))
            .RuleFor(x => x.MaxPowerCurrent, x => x.Random.Double(10, 15))
            .RuleFor(x => x.MaxPowerVoltage, x => x.Random.Double(40, 50))
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.NLVoltage, x => x.Random.Double(50, 60))
            .RuleFor(x => x.Power, x => x.PickRandom(new List<double> { 380, 400, 450, 420 }))
            .RuleFor(x => x.SCCurrent, x => x.Random.Double(15, 18))
            .RuleFor(x => x.SVT, x => x.Random.Int(0, 99999))
            .RuleFor(x => x.Weight, x => x.Random.Double(20, 25));
    }
}

