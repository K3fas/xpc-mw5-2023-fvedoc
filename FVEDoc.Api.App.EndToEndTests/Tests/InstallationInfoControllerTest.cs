using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.InstallationInfo;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class InstallationInfoControllerTest : TestBase<InstallationInfoModel, InstallationInfoModel>
{
    public InstallationInfoControllerTest()
        : base("installation-info", BogusSeeder.SeedInstallationInfoModel())
    {

    }
}

