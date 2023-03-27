using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.PVPanel;
public class PVPanelModel : DbBase
{
    public required string Name { get; set; }
    public required int SVT { get; set; }
    public required double Power { get; set; }
    public required double Efficiency { get; set; }
    public required double MaxPowerVoltage { get; set; }
    public required double MaxPowerCurrent { get; set; }
    public required double NLVoltage { get; set; }
    public required double SCCurrent { get; set; }
    public required Size Size { get; set; }
    public required double Weight { get; set; }
}
