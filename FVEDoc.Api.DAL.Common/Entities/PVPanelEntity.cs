using FVEDoc.Common;

namespace FVEDoc.Api.DAL.Common.Entities;
public class PVPanelEntity : EntityBase
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

