using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Enums;
public enum OrderStatus
{
    Unknown = 0,
    Pending = 1,
    InProcess = 2,
    Incomplete = 3,
    ToBeApproved = 4,
    Done = 5,
}
