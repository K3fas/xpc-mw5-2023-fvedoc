using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.PVPanel;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("pv-panel")]
public class PVPanelController : BasicController<PVPanelEntity, PVPanelModel>
{
    public PVPanelController(ILogger<PVPanelController> logger, IPVPanelFacade facade)
        : base(logger, facade)
    {
    }
}
