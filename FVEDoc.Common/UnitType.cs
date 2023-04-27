using FVEDoc.Common.Enums;

namespace FVEDoc.Common;
public struct UnitType<TData>
{
    public required TData Value { get; set; }
    public required Units Unit { get; set; }
}
