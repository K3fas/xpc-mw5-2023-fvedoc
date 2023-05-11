using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.PropertyInfo;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class PropertyInfoControllerTest : TestBase<PropertyInfoModel, PropertyInfoModel>
{
    public PropertyInfoControllerTest()
        : base("property-info", BogusSeeder.SeedPropertyInfoModel())
    {

    }

}

