using FVEDoc.Api.DAL.Common.Entities.Interfaces;

namespace FVEDoc.Api.DAL.Common.Entities;
public class EntityBase : IEntity
{
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset DateModified { get; set; }
    public Guid Id { get; init; }
}
