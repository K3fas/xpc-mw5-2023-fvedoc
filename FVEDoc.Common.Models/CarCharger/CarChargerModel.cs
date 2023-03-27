using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.Models.CarCharger;
public class CarChargerModel : DbBase
{
    public string Name { get; set; }
    public double Power { get; set; }
}
