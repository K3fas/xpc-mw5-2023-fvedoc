using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Order;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class OrderMapperProfile : Profile
{
    public OrderMapperProfile()
    {
        CreateMap<OrderEntity, OrderModel>()
            .ForMember(dest => dest.InstallationType, src => src.Ignore());
        CreateMap<OrderModel, OrderEntity>()
            .ForMember(dest => dest.InstallationType, src => src.MapFrom(x => x.InstallationType.Id))
            .ForMember(dest => dest.DateCreated, src => src.Ignore())
            .ForMember(dest => dest.DateModified, src => src.Ignore());
    }
}

