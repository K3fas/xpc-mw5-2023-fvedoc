using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common;
public class DbBase : IDbBase
{
    public required Guid Id { get; init; }
    public required DateTimeOffset DateCreated { get; init; }
    public required DateTimeOffset DateModified { get; init; }
}
