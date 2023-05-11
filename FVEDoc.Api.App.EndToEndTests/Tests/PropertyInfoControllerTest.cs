using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.Order;
using FVEDoc.Common.Models.PropertyInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class PropertyInfoControllerTest : TestBase<PropertyInfoModel, PropertyInfoModel>
{
    public PropertyInfoControllerTest()
        : base("property-info", BogusSeeder.SeedPropertyInfoModel())
    {

    }

}

