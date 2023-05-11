using FVEDoc.Api.DAL.Mock;
using FVEDoc.Common.Models.PVPanel;

namespace FVEDoc.Api.App.EndToEndTests.Tests;
public class PVPanelControllerTest : TestBase<PVPanelModel, PVPanelModel>
{
    public PVPanelControllerTest()
        : base("pv-panel", BogusSeeder.SeedPVPanelModel())
    {

    }
}

