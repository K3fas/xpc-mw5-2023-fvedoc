using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CadastreData;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface ICadastreFacade : IFacadeBase<CadastreDataEntity, CadastreDataModel>, IApiFacade
{
}

