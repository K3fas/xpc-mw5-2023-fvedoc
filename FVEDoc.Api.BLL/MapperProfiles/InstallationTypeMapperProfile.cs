using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.InstallationType;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class InstallationTypeMapperProfile : MapperBase<InstallationTypeEntity, InstallationTypeModel>
{
    public InstallationTypeMapperProfile()
    {
        CreateMap<InstallationTypeEntity, InstallationTypeListModel>()
            .ForMember(dest => dest.BatteryName, src => src.MapFrom(x => x.Battery == null ? null : x.Battery.Name))
            .ForMember(dest => dest.CarChargerName, src => src.MapFrom(x => x.CarCharger == null ? null : x.CarCharger.Name))
            .ForMember(dest => dest.InverterName, src => src.MapFrom(x => x.Inverter.Name))
            .ForMember(dest => dest.PVPanelName, src => src.MapFrom(x => x.PVPanel.Name));
    }
}

