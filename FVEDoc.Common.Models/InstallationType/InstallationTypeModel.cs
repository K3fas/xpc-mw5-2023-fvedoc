using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.Inverter;
using FVEDoc.Common.Models.PVPanel;

namespace FVEDoc.Common.Models.InstallationType;
public class InstallationTypeModel : ModelBase
{
    public required string PVTypeID { get; set; }
    public required double Power { get; set; }
    public InverterModel? Inverter { get; set; }
    public PVPanelModel? PVPanel { get; set; }
    public required int PVPanelCount { get; set; }
    public BatteryModel? Battery { get; set; }
    public CarChargerModel? CarCharger { get; set; }

}

