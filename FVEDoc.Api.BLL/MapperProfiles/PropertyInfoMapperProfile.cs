using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Common.Models.PropertyInfo;
using static MongoDB.Driver.WriteConcern;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class PropertyInfoMapperProfile : Profile
{
    public PropertyInfoMapperProfile()
    {
        CreateMap<PropertyInfoEntity, PropertyInfoModel>()
            .ForMember(dest => dest.CadastreData, src => src.Ignore());
        CreateMap<PropertyInfoModel, PropertyInfoEntity>()
            .ForMember(dest => dest.CadastreData, src => src.MapFrom(x => x.CadastreData.Id))
            .ForMember(dest => dest.DateCreated, src => src.Ignore())
            .ForMember(dest => dest.DateModified, src => src.Ignore());
    }
}

