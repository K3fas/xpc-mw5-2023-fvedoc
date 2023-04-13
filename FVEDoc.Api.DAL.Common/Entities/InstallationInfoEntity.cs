namespace FVEDoc.Api.DAL.Common.Entities;
public class InstallationInfoEntity : EntityBase
{
    public required InstallationTypeEntity InstallationType { get; set; }
    public required IList<int> PVStrings { get; set; }
    public required string TechnologyPlace { get; set; }
    public required int CYADiameter { get; set; }
    public required string SolarCable { get; set; }
}

