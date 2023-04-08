using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.Battery;
public class BatteryListModel : ModelBase
{
    public required string Name { get; set; }
    public required double TotalCapacity { get; set; }
}

