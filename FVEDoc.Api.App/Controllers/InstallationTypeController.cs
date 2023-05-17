using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models;
using FVEDoc.Common.Models.InstallationType;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static MongoDB.Driver.WriteConcern;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("installation-type")]
public class InstallationTypeController : BasicController<InstallationTypeEntity, InstallationTypeModel>
{

    public InstallationTypeController(ILogger<InstallationTypeController> logger, IInstallationTypeFacade facade)
        : base(logger, facade)
    {
    }
    [HttpGet("", Order = -1)]
    public override async Task<Results<NoContent, Ok<IEnumerable<IModelBase>>>> GetAllAsync()
    {
        _logger.LogInformation("Getting all models");
        try
        {
            var list = (IEnumerable<IModelBase>)await _facade.GetAllAsync<InstallationTypeListModel>();
            return list.Any() ? TypedResults.Ok(list) : TypedResults.NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Method GetAllAsync failed");
            Console.WriteLine(ex.Message);
            return TypedResults.NoContent();
        }
    }
}
