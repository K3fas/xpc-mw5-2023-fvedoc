using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CarCharger;
using FVEDoc.Common.Models.InstallationInfo;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Web.BLL.Facades;
public class InstallationInfoFacade : FacadeBase<InstallationInfoModel, InstallationInfoListModel>, IWebFacade
{
    public InstallationInfoFacade(InstallationInfoRepository repo, ILogger<BatteryFacade> logger)
        : base(repo, logger)
    {
    }
}

