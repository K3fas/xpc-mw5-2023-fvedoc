using FVEDoc.Common.Models.InstallationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.InstallationInfo;
public class InstallationInfoModel : ModelBase
{
    public required InstallationTypeModel InstallationType { get; set; }
    public required IList<int> PVStrings { get; set; }
    public required string TechnologyPlace { get; set; }
    public required int CYADiameter { get; set; }
    public required string SolarCable { get; set; }
}
