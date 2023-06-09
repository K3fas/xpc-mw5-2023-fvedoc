﻿namespace FVEDoc.Common.Models.Inverter;
public class InverterModel : ModelBase
{
    public required string Name { get; set; }
    public required int SVT { get; set; }
    public required double MaxDCPower { get; set; }
    public required double MaxACPower { get; set; }
    public required double NominalACVoltage { get; set; }
    public required double Efficiency { get; set; }
    public required double IPCover { get; set; }

}
