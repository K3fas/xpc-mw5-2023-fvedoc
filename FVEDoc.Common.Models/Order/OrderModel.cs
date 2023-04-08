using FVEDoc.Common.Models.InstallationType;
using FVEDoc.Common.Models.PVTypeId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.Order;
public class OrderModel : ModelBase
{
    public int OrderId { get; set; }
    public InstallationTypeModel InstallationType{ get; set; }
    
}
