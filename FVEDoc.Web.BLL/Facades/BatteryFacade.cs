using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Battery;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Web.BLL.Facades;
public class BatteryFacade : FacadeBase<BatteryModel, BatteryListModel>, IWebFacade
{
    public BatteryFacade(BatteryRepository repo, ILogger<BatteryFacade> logger)
        :base(repo, logger)
    {
    }
}

