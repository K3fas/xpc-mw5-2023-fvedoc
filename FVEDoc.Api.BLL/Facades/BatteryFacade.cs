using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models.Battery;

namespace FVEDoc.Api.BLL.Facades;
public class BatteryFacade : FacadeBase<BatteryEntity, BatteryModel>, IBatteryFacade
{
    public BatteryFacade(IBatteryRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }

    public List<BatteryListModel> GetListModels()
    {
        return _mapper.Map<List<BatteryListModel>>(_repository.GetAllAsync());
    }
}

