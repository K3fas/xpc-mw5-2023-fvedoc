namespace FVEDoc.Api.DAL.Common.Entities;
public class InstallationTypeEntity : EntityBase
{
    public required string PVTypeID { get; set; }
    public required double Power { get; set; }
    public required Guid Inverter { get; set; }
    public required Guid PVPanel { get; set; }
    public required int PVPanelCount { get; set; }
    public Guid? Battery { get; set; }
    public Guid? CarCharger { get; set; }
}

