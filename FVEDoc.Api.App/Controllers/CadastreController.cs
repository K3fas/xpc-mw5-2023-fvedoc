using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.CadastreData;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("[controller]")]
public class CadastreController : BasicController<CadastreDataEntity, CadastreDataModel>
{
    public CadastreController(ILogger<CadastreController> logger, ICadastreFacade facade)
        : base(logger, facade)
    {
    }
}
