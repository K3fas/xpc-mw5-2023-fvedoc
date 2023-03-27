using FVEDoc.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common;
public struct UnitType<DataType>
{
    public required DataType Value { get; set; }
    public required Units Unit { get; set; }
}
