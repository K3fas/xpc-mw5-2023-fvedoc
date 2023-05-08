using FVEDoc.Common.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace FVEDoc.Common;
public class ModelBase : IModelBase
{
    public required Guid Id { get; init; }

}
