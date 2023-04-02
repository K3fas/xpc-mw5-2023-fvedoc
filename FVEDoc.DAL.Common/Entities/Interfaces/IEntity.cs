using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities.Interfaces;
public interface IEntity : IWithId
{
    DateTimeOffset DateCreated { get; set; }
    DateTimeOffset DateModified { get; set; }
}
