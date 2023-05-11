using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.InstallationInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class InstallationInfoControllerTest : TestBase<InstallationInfoModel, InstallationInfoModel>
{
    public InstallationInfoControllerTest()
        :base("installation-info", BogusSeeder.SeedInstallationInfoModel())
    {

    }
}

