using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.InstallationInfo;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class InstallationInfoMapperProfile : MapperBase<InstallationInfoEntity, InstallationInfoModel>
{
    public InstallationInfoMapperProfile()
    {

        //CreateMap<InstallationInfoEntity, InstallationInfoModel>()
        //    .ForMember(dest => dest.InstallationType, act => act.MapFrom(src => src.InstallationType));
        //CreateMap<InstallationInfoModel, InstallationInfoEntity>()
        //    .ForMember(dest => dest.InstallationType, act => act.MapFrom(src => src.InstallationType));

    }
}

