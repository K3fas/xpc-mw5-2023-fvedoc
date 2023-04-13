namespace FVEDoc.Api.DAL.Common.Entities;
public class OrderEntity : EntityBase
{
    public int OrderId { get; set; }
    public InstallationTypeEntity? InstallationType { get; set; }
}

