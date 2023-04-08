using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface IBatteryFacade : IFacadeBase<BatteryEntity, BatteryModel>, IAppFacade
{
    List<BatteryListModel> GetListModels();
}

