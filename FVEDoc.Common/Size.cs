using FVEDoc.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common;
public struct Size
{
    public UnitType<double> Height { get; set; }
    public UnitType<double> Width { get; set; }
    public UnitType<double> Depth { get; set; }
}
