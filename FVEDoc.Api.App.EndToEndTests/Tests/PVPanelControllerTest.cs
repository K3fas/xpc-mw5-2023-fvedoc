using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.PropertyInfo;
using FVEDoc.Common.Models.PVPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class PVPanelControllerTest : TestBase<PVPanelModel, PVPanelModel>
{
    public PVPanelControllerTest()
        : base("pv-panel", BogusSeeder.SeedPVPanelModel())
    {

    }
}

