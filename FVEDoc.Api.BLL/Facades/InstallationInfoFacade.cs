using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.InstallationInfo;

namespace FVEDoc.Api.BLL.Facades;
public class InstallationInfoFacade : FacadeBase<InstallationInfoEntity, InstallationInfoModel>, IInstallationInfoFacade
{
    public InstallationInfoFacade(IInstallationInfoRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

