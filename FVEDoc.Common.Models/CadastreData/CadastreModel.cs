using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.CadastreData;
public class CadastreDataModel : WithId
{
    public required int ParcelNumber { get; set; }
    public required string CityID { get; set; }
    public required string CadastreID { get; set; }
    public required int PLNumber { get; set; }
}
