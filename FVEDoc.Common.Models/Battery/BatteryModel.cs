namespace FVEDoc.Common.Models.Battery;
public class BatteryModel : ModelBase
{
    public required string Name{ get; set; }
    public required double TotalCapacity { get; set; }
    public required int BlockCount { get; set; }
    public required double BlockCapacity { get; set; }
    public required string BlockTechnology { get; set; }
    public required double NominalVoltage { get; set; }
    public required string LifeExpectacy { get; set; }
    public required double ContinuousDischarge { get; set; }
    public required double ContinuousCharge { get; set; }
    public required Size Size { get; set; }
    public required double Weigth { get; set; }
}
