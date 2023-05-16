using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.InstallationType;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class InstallationTypeControllerTest : TestBase<InstallationTypeModel, InstallationTypeModel>
{
    public InstallationTypeControllerTest()
        : base("installation-type", BogusSeeder.SeedInstallationTypeModel())
    {

    }
}

