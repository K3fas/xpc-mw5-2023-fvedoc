using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common;
public class WithId : IWithId
{
    public required Guid Id { get; init; }

}
