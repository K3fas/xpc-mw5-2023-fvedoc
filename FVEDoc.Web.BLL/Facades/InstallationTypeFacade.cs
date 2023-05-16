using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.InstallationType;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Web.BLL.Facades;
public class InstallationTypeFacade : FacadeBase<InstallationTypeModel, InstallationTypeListModel>, IWebFacade
{
    public InstallationTypeFacade(InstallationTypeRepository repo, ILogger<BatteryFacade> logger)
        : base(repo, logger)
    {
    }
}

