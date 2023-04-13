using FVEDoc.DAL.Common;

namespace FVEDoc.Api.DAL.Common.Entities.Interfaces;
public interface IEntity : IModelBase
{
    DateTimeOffset DateCreated { get; set; }
    DateTimeOffset DateModified { get; set; }
}
