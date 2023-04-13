using FVEDoc.Common.Enums;

namespace FVEDoc.Common;
public struct UnitType<DataType>
{
    public required DataType Value { get; set; }
    public required Units Unit { get; set; }
}
