using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.CarCharger;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("car-charger")]
public class CarChargerController : BasicController<CarChargerEntity, CarChargerModel>
{
    public CarChargerController(ILogger<CarChargerController> logger, ICarChargerFacade facade)
        : base(logger, facade)
    {
    }
}
