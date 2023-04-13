using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Battery;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface IBatteryFacade : IFacadeBase<BatteryEntity, BatteryModel>, IApiFacade
{
    List<BatteryListModel> GetListModels();
}

