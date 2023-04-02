using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities;
public class OrderEntity : EntityBase
{
    public int OrderId { get; set; }
    public InstallationTypeEntity? InstallationType { get; set; }
}

