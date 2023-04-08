using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common;
public class ModelBase : IModelBase
{
    public required Guid Id { get; init; }

}
