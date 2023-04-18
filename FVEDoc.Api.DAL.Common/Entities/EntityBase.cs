using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using MongoDB.Bson.Serialization.Attributes;

namespace FVEDoc.Api.DAL.Common.Entities;
public class EntityBase : IEntity
{
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset DateModified { get; set; }
    [BsonId]
    public Guid Id { get; init; }
}
