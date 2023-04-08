using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities;
public class PropertyInfoEntity :EntityBase
{
    public CadastreDataEntity? CadastreData { get; set; }
    public int? MainCB { get; set; }
    public string? MainCBPlace { get; set; }
    public int? OccupantsCount { get; set; }
    public string? MainHeating { get; set; }
    public string? WaterHeating { get; set; }
}

