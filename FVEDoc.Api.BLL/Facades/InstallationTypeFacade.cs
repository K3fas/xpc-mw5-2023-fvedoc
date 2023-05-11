using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models.InstallationType;

namespace FVEDoc.Api.BLL.Facades;
public class InstallationTypeFacade : FacadeBase<InstallationTypeEntity, InstallationTypeModel>, IInstallationTypeFacade
{
    private readonly IInverterFacade _inverters;
    private readonly IPVPanelFacade _panels;
    private readonly IBatteryFacade _batteries;
    private readonly ICarChargerFacade _carChargers;

    public InstallationTypeFacade(IInstallationTypeRepository repository,
                                  IMapper mapper,
                                  IInverterFacade inverters,
                                  IPVPanelFacade panels,
                                  IBatteryFacade batteries,
                                  ICarChargerFacade carChargers)
        : base(repository, mapper)
    {
        _inverters=inverters;
        _panels=panels;
        _batteries=batteries;
        _carChargers=carChargers;
    }


    public override async Task<InstallationTypeModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        var entity = await _repository.GetByIdAsync(id, c);
        if (entity == null)
            return null;

        var model = _mapper.Map<InstallationTypeModel>(entity);

        model.Inverter = await _inverters.GetByIdAsync(entity.Inverter, c);
        model.PVPanel = await _panels.GetByIdAsync(entity.PVPanel, c);
        model.Battery = await _batteries.GetByIdAsync(entity.Battery.GetValueOrDefault(), c);
        model.CarCharger = await _carChargers.GetByIdAsync(entity.CarCharger.GetValueOrDefault(), c);

        return model;
    }

}

