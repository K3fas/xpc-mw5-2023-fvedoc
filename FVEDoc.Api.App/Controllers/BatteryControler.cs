using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Battery;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

[ApiController]
[Route("battery")]
public class BatteryControler :  BasicController<BatteryEntity, BatteryModel>
{
    private readonly ILogger<BatteryControler> _logger;
    private readonly IBatteryFacade _battery;

    public BatteryControler(ILogger<BatteryControler> logger, IBatteryFacade battery)
        :base(logger, battery)
    {
        _logger=logger;
        _battery=battery;
    }

    [HttpGet]
    [Route("list")]
    public IEnumerable<BatteryListModel> GetList()
    {
        _logger.LogInformation("Getting battery model list");
        return _battery.GetListModels();
    }


}
