namespace FVEDoc.Common.Models.InstallationType;
public class InstallationTypeListModel : ModelBase
{
    public required string PVTypeID { get; set; }
    public required double Power { get; set; }
    public required string InverterName { get; set; }
    public required string PVPanelName{ get; set; }
    public required int PVPanelCount { get; set; }
    public string? BatteryName { get; set; }
    public string? CarChargerName { get; set; }

}

