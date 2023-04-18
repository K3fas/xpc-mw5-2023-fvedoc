namespace FVEDoc.Common.Models.CadastreData;
public class CadastreDataModel : ModelBase
{
    public required string ParcelNumber { get; set; }
    public required string CityID { get; set; }
    public required string CadastreID { get; set; }
    public required int PLNumber { get; set; }
}
