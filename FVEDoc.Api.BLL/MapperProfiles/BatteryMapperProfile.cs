using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Battery;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class BatteryMapperProfile : MapperBase<BatteryEntity, BatteryModel>
{
    public BatteryMapperProfile()
    {
        CreateMap<BatteryEntity, BatteryListModel>();
    }
}

