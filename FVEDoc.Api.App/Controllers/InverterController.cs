using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Inverter;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("[controller]")]
public class InverterController : BasicController<InverterEntity, InverterModel>
{
    public InverterController(ILogger<InverterController> logger, IInverterFacade facade)
        : base(logger, facade)
    {
    }
}
