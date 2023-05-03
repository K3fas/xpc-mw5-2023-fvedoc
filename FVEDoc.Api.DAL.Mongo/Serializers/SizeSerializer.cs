using FVEDoc.Common;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;


namespace FVEDoc.Api.DAL.Mongo.Serializers;
public class SizeSerializer : SerializerBase<Size>
{
    public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, Size value)
    {
        context.Writer.WriteStartDocument();

        context.Writer.WriteStartDocument(nameof(value.Height));
        BsonSerializer.Serialize(context.Writer,value.Height);
        context.Writer.WriteEndDocument();

        context.Writer.WriteStartDocument(nameof(value.Width));
        BsonSerializer.Serialize(context.Writer,value.Width);
        context.Writer.WriteEndDocument();

        context.Writer.WriteStartDocument(nameof(value.Depth));
        BsonSerializer.Serialize(context.Writer,value.Depth);
        context.Writer.WriteEndDocument();

        context.Writer.WriteEndDocument();
    }

    public override Size Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
    {

        Size result = new();
        var reader = context.Reader;

        if(reader.State == BsonReaderState.Value)
        {
            reader.ReadStartDocument();

            reader.ReadBsonType();
            reader.ReadName();
            result.Height = BsonSerializer.Deserialize<UnitType>(reader);
            reader.ReadBsonType();
            reader.ReadName();
            result.Width = BsonSerializer.Deserialize<UnitType>(reader);
            reader.ReadBsonType();
            reader.ReadName();
            result.Depth = BsonSerializer.Deserialize<UnitType>(reader);

            reader.ReadEndDocument();
        }


        return result;
    }

}

