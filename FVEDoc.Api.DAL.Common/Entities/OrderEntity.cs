namespace FVEDoc.Api.DAL.Common.Entities;
public class OrderEntity : EntityBase
{
    public int OrderId { get; set; }
    public Guid? InstallationType { get; set; }
}

