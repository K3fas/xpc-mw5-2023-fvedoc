using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CadastreData;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;


namespace FVEDoc.Web.BLL.Facades;
public class CadastreFacade : FacadeBase<CadastreDataModel, CadastreDataListModel>, IWebFacade
{
    public CadastreFacade(CadastreRepository repo, ILogger<BatteryFacade> logger)
        : base(repo, logger)
    {
    }
}
