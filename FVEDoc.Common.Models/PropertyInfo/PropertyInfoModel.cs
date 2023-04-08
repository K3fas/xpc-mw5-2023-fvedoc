using FVEDoc.Common.Models.CadastreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.PropertyInfo;
public class PropertyInfoModel : ModelBase
{
    public CadastreDataModel? CadastreData { get; set; }
    public int? MainCB { get; set; }
    public string? MainCBPlace { get; set; }
    public int? OccupantsCount { get; set; }
    public string? MainHeating { get; set; }
    public string? WaterHeating { get; set; }

}
