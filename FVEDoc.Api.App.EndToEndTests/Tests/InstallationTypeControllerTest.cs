using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.InstallationInfo;
using FVEDoc.Common.Models.InstallationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class InstallationTypeControllerTest : TestBase<InstallationTypeModel, InstallationTypeModel>
{
    public InstallationTypeControllerTest()
        : base("installation-type", BogusSeeder.SeedInstallationTypeModel())
    {

    }
}

