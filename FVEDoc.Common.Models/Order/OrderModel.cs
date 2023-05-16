using FVEDoc.Common.Models.InstallationType;

namespace FVEDoc.Common.Models.Order;
public class OrderModel : ModelBase
{
    public int OrderId { get; set; }
    public InstallationTypeModel? InstallationType { get; set; }

}
