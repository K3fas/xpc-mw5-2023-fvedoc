using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Order;

namespace FVEDoc.Api.BLL.Facades;
public class OrderFacade : FacadeBase<OrderEntity, OrderModel>, IOrderFacade
{
    private readonly IInstallationTypeFacade _typeFacade;

    public OrderFacade(IOrderRepository repository, IMapper mapper, IInstallationTypeFacade typeFacade)
        : base(repository, mapper)
    {
        _typeFacade=typeFacade;
    }

    public override async Task<OrderModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        var entity = await _repository.GetByIdAsync(id, c);
        if (entity is null)
            return null;

        var model = _mapper.Map<OrderModel>(entity);
        model.InstallationType = await _typeFacade.GetByIdAsync(entity.InstallationType.GetValueOrDefault(), c);

        return model;
    }
}

