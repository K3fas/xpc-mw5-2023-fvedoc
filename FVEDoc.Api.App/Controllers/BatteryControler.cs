using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models;
using FVEDoc.Common.Models.Battery;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

[ApiController]
[Route("battery")]
public class BatteryControler :  BasicController<BatteryEntity, BatteryModel>
{
    private readonly ILogger<BatteryControler> _logger;

    public BatteryControler(ILogger<BatteryControler> logger, IBatteryFacade battery)
        :base(logger, battery)
    {
        _logger=logger;
    }

    [HttpGet("", Order = -1)]
    public async override Task<Results<NoContent, Ok<IEnumerable<IModelBase>>>> GetAllAsync()
    {
        _logger.LogInformation("Getting battery model list");
        try
        {
            IEnumerable<IModelBase> list = await _facade.GetAllAsync<BatteryListModel>();
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
