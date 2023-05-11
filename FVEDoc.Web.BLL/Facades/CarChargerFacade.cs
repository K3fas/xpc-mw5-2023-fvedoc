using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;


namespace FVEDoc.Web.BLL.Facades;
public class CarChargerFacade : FacadeBase<CarChargerModel, CarChargerListModel>, IWebFacade
{
    public CarChargerFacade(CarChargerRepository repo, ILogger<BatteryFacade> logger)
        : base(repo, logger)
    {
    }
}

