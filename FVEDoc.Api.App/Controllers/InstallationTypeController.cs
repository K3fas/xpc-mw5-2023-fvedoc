﻿using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models.InstallationType;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("[controller]")]
public class InstallationTypeController : BasicController<InstallationTypeEntity, InstallationTypeModel>
{
    public InstallationTypeController(ILogger<InstallationTypeController> logger, IInstallationTypeFacade facade)
        : base(logger, facade)
    {
    }
}
