using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Common.Models.InstallationInfo;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class InstallationInfoMapperProfile : Profile
{
    public InstallationInfoMapperProfile()
    {
        CreateMap<InstallationInfoEntity, InstallationInfoModel>()
            .ForMember(dest => dest.InstallationType, src => src.Ignore());

        CreateMap<InstallationInfoModel, InstallationInfoEntity>()
            .ForMember(dest => dest.DateCreated, src => src.Ignore())
            .ForMember(dest => dest.DateModified, src => src.Ignore())
            .ForMember(dest => dest.InstallationType, src => src.Ignore());
    }
}

