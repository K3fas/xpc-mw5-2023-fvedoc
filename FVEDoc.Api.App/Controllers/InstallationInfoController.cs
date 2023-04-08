using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.InstallationInfo;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("[controller]")]
public class InstallationInfoController : BasicController<InstallationInfoEntity, InstallationInfoModel>
{
    public InstallationInfoController(ILogger<InstallationInfoController> logger, IInstallationInfoFacade facade)
        : base(logger, facade)
    {
    }
}
