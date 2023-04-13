namespace FVEDoc.Common.Models.Battery;
public class BatteryListModel : ModelBase
{
    public required string Name { get; set; }
    public required double TotalCapacity { get; set; }
}

