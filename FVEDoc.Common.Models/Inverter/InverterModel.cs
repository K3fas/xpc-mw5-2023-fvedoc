using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.Inverter;
public class InverterModel : DbBase
{
    public required string Name { get; set; }
    public required int SVT { get; set; }
    public required double MaxDCPower { get; set; }
    public required double MaxACPower { get; set; }
    public required double NominalACVoltage { get; set; }
    public required double Efficiency { get; set; }
    public required double IPCover { get; set; }

}
