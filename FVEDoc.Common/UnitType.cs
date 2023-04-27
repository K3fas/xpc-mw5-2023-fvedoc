using FVEDoc.Common.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace FVEDoc.Common;
public struct UnitType
{
    public required double Value { get; set; }
    public required Units Unit { get; set; }

}
