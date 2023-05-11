using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.InstallationType;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class InstallationTypeMapperProfile : Profile
{
    public InstallationTypeMapperProfile()
    {
        CreateMap<InstallationTypeEntity, InstallationTypeModel>()
            .ForMember(dest => dest.Inverter, src => src.Ignore())
            .ForMember(dest => dest.PVPanel, src => src.Ignore())
            .ForMember(dest => dest.Battery, src => src.Ignore())
            .ForMember(dest => dest.CarCharger, src => src.Ignore());

        CreateMap<InstallationTypeModel, InstallationTypeEntity>()
            .ForMember(dest => dest.Inverter, src => src.MapFrom(x => x.Inverter.Id))
            .ForMember(dest => dest.PVPanel, src => src.MapFrom(x => x.PVPanel.Id))
            .ForMember(dest => dest.Battery, src => src.MapFrom(x => x.Battery.Id))
            .ForMember(dest => dest.CarCharger, src => src.MapFrom(x => x.CarCharger.Id))
            .ForMember(dest => dest.DateCreated, src => src.Ignore())
            .ForMember(dest => dest.DateModified, src => src.Ignore());

        CreateMap<InstallationTypeModel, InstallationTypeListModel>()
            .ForMember(dest => dest.BatteryName, src => src.MapFrom(x => x.Battery == null ? null : x.Battery.Name))
            .ForMember(dest => dest.CarChargerName, src => src.MapFrom(x => x.CarCharger == null ? null : x.CarCharger.Name))
            .ForMember(dest => dest.InverterName, src => src.MapFrom(x => x.Inverter.Name))
            .ForMember(dest => dest.PVPanelName, src => src.MapFrom(x => x.PVPanel.Name));
    }
}

