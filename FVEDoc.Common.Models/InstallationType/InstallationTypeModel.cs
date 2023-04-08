using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.Inverter;
using FVEDoc.Common.Models.PVPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.InstallationType;
public class InstallationTypeModel : ModelBase
{
    public required string PVTypeID { get; set; }
    public required double Power { get; set; }
    public required InverterModel Inverter { get; set; }
    public required PVPanelModel PVPanel{ get; set; }
    public required int PVPanelCount { get; set; }
    public BatteryModel? Battery{ get; set; }
    public CarChargerModel? CarCharger { get; set; }

}

