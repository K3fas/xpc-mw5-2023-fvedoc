using FVEDoc.Common;
using FVEDoc.Common.Enums;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;


namespace FVEDoc.Api.DAL.Mongo.Serializers;
public class UnitTypeSerializer : SerializerBase<UnitType>
{
    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, UnitType value)
    {
        context.Writer.WriteDouble(nameof(value.Value),value.Value);
        context.Writer.WriteInt32(nameof(value.Unit), (int)value.Unit);
    }
    public override UnitType Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
    {
        var reader = context.Reader;
        UnitType result = default;
        reader.ReadStartDocument();

        reader.ReadBsonType();
        reader.ReadName();
        result.Value = reader.ReadDouble();
        reader.ReadBsonType();
        reader.ReadName();
        result.Unit = (Units)reader.ReadInt32();

        reader.ReadEndDocument();

        return result;
    }
}

