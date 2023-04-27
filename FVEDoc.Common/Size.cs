using FVEDoc.Common.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace FVEDoc.Common;
public struct Size
{
    public UnitType Height { get; set; }
    public UnitType Width { get; set; }
    public UnitType Depth { get; set; }
}
