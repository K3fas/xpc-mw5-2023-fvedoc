using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

[ApiController]
[Route("[controller]")]
public class BatteryControler : ControllerBase
{
    private readonly ILogger<BatteryControler> _logger;
    private readonly IBatteryRepository _batteries;

    public BatteryControler(ILogger<BatteryControler> logger, IBatteryRepository battery)
    {
        _logger=logger;
        _batteries=battery;
    }

    // TODO: This should be model!
    [HttpGet(Name ="GetAll")]
    public IEnumerable<BatteryEntity> GetAll()
    {
        return _batteries.GetAll().AsEnumerable();
    }


}
