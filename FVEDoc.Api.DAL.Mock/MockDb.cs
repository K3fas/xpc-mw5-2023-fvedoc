using Bogus;
using FVEDoc.Api.DAL.Common.Entities;

namespace FVEDoc.Api.DAL.Mock;
public class MockDb
{
    public IList<BatteryEntity> Batteries { get; } = new List<BatteryEntity>();
    public IList<CadastreDataEntity> CadastreData { get; } = new List<CadastreDataEntity>();
    public IList<CarChargerEntity> CarChargers { get; } = new List<CarChargerEntity>();
    public IList<CustomerEntity> Customers { get; } = new List<CustomerEntity>();
    public IList<InstallationInfoEntity> InstallationInfos { get; } = new List<InstallationInfoEntity>();
    public IList<InstallationTypeEntity> InstallationTypes { get; } = new List<InstallationTypeEntity>();
    public IList<InverterEntity> Inverters { get; } = new List<InverterEntity>();
    public IList<OrderEntity> Orders { get; } = new List<OrderEntity>();
    public IList<PropertyInfoEntity> PropertyInfos { get; } = new List<PropertyInfoEntity>();
    public IList<PVPanelEntity> PVPanels { get; } = new List<PVPanelEntity>();

    public MockDb(bool seedData = true)
    {
        if (seedData)
        {
            SeedBogusData();
        }
    }

    public void SeedBogusData()
    {
        BogusSeeder.SeedData(this);
    }

}

