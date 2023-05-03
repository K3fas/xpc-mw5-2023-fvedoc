using FVEDoc.Common.Models;

namespace FVEDoc.Common;
public class ModelBase : IModelBase
{
    public required Guid Id { get; init; }

}
