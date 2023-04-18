using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.InstallationType;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("installation-type")]
public class InstallationTypeController : BasicController<InstallationTypeEntity, InstallationTypeModel>
{
    private readonly IInstallationTypeFacade _facade;

    public InstallationTypeController(ILogger<InstallationTypeController> logger, IInstallationTypeFacade facade)
        : base(logger, facade)
    {
        _facade=facade;
    }
    //[HttpGet("", Order = -1)]
    //public override IEnumerable<InstallationTypeListModel> GetAllAsyc()
    //{
    //    return _facade.GetAll<InstallationTypeListModel>();
    //}
}
