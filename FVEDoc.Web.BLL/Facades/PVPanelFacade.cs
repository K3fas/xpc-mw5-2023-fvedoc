using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.PVPanel;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Web.BLL.Facades;
public class PVPanelFacade : FacadeBase<PVPanelModel, PVPanelListModel>, IWebFacade
{
    public PVPanelFacade(PVPanelRepository repo, ILogger<BatteryFacade> logger)
        : base(repo, logger)
    {
    }
}

