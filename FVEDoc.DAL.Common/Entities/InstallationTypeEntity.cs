using FVEDoc.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities;
public class InstallationTypeEntity : EntityBase
{
    public required string PVTypeID { get; set; }
    public required UnitType<double> Power { get; set; }
    public required InverterEntity Inverter { get; set; }
    public required PVPanelEntity PVPanel { get; set; }
    public required int PVPanelCount { get; set; }
    public BatteryEntity? Battery { get; set; }
    public CarChargerEntity? CarCharger { get; set; }
}

