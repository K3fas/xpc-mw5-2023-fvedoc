using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Entities;
public class CarChargerEntity : EntityBase
{
    public required string Name { get; set; }
    public double Power { get; set; }
}

