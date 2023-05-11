using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models.InstallationInfo;
using FVEDoc.Common.Models.InstallationType;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FVEDoc.Api.BLL.Facades;
public class InstallationInfoFacade : FacadeBase<InstallationInfoEntity, InstallationInfoModel>, IInstallationInfoFacade
{
    private readonly IInstallationTypeRepository _installationType;

    public InstallationInfoFacade(IInstallationInfoRepository repository, IMapper mapper, IInstallationTypeRepository installationType)
    : base(repository, mapper)
    {
        _installationType=installationType; _installationType=installationType;
    }

    public override async Task<Guid?> CreateAsync(InstallationInfoModel model, CancellationToken c = default)
    {
        if (await _repository.ExistsAsync(model.Id, c))
            return null;

        var entity = _mapper.Map<InstallationInfoEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;
        if (model.InstallationType is null)
            return null;

        entity.InstallationType = model.InstallationType.Id;

        return await _repository.InsertAsync(entity, c);
    }

    public override async Task<(Guid? id, bool created)> CreateOrUpdateAsync(InstallationInfoModel model, CancellationToken c = default)
    {
        return await _repository.ExistsAsync(model.Id, c)
           ? (await UpdateAsync(model, c), false)
           : (await CreateAsync(model, c), true);

    }

    public override async Task<InstallationInfoModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        if (!await _repository.ExistsAsync(id, c))
            return null;

        var entity = await _repository.GetByIdAsync(id, c);
        var model = _mapper.Map<InstallationInfoModel>(entity);

        if (entity?.InstallationType is not null)
        {
            var typeE = await _installationType.GetByIdAsync(entity.InstallationType.Value, c);
            var type = _mapper.Map<InstallationTypeModel>(typeE);
            model.InstallationType = type;
        }

        return model;
    }

    public override async Task<Guid?> UpdateAsync(InstallationInfoModel model, CancellationToken c = default)
    {

        var entity = _mapper.Map<InstallationInfoEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;
        if (model.InstallationType is null)
            return null;

        entity.InstallationType = model.InstallationType.Id;

        return await _repository.UpdateAsync(entity, c);
    }



}

