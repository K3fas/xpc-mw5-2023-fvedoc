using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models.CarCharger;

namespace FVEDoc.Api.BLL.Facades;
public class CarChargerFacade : FacadeBase<CarChargerEntity, CarChargerModel>, ICarChargerFacade
{
    public CarChargerFacade(ICarChargerRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

