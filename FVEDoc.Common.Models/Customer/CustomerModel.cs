using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.Customer;
public class CustomerModel : ModelBase
{
    public required string Name { get; set; }
    public string? CompanyID { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public required string ZIP { get; set; }

}
