using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities;
public class CadastreDataEntity : EntityBase
{
    public required int ParcelNumber { get; set; }
    public required string CityID { get; set; }
    public required string CadastreID { get; set; }
    public required int PLNumber { get; set; }
}

