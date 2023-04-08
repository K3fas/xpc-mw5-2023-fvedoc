using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities;
public class CustomerEntity : EntityBase
{
    public required string Name { get; set; }
    public string? CompanyID { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public required string ZIP { get; set; }
}

