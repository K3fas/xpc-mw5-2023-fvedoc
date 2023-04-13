using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Inverter;

namespace FVEDoc.Api.BLL.Facades;
public class InverterFacade : FacadeBase<InverterEntity, InverterModel>, IInverterFacade
{
    public InverterFacade(IInverterRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

