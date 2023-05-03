using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models;

namespace FVEDoc.Api.BLL.Facades;
public abstract class FacadeBase<TEntity, TModel> : IFacadeBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    protected readonly IApiRepository<TEntity> _repository;
    protected readonly IMapper _mapper;

    public FacadeBase(IApiRepository<TEntity> repository, IMapper mapper)
    {
        _repository=repository;
        _mapper=mapper;
    }

    public virtual async Task<Guid?> CreateAsync(TModel model, CancellationToken c = default)
    {
        if (await _repository.ExistsAsync(model.Id, c))
            return null;

        var entity = _mapper.Map<TEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;

        return await _repository.InsertAsync(entity, c);
    }

    public virtual async Task<Guid?> CreateOrUpdateAsync(TModel model, CancellationToken c = default)
    {
        return await _repository.ExistsAsync(model.Id, c)
            ? await UpdateAsync(model, c)
            : await CreateAsync(model, c);
    }

    public virtual async Task<Guid?> DeleteAsync(Guid id, CancellationToken c)
    {
        return await _repository.ExistsAsync(id, c) ? await _repository.DeleteAsync(id, c) ? id : null : null;
    }

    public virtual async Task<List<TListModel>> GetAllAsync<TListModel>(CancellationToken c = default) where TListModel : IModelBase
    {
        return _mapper.Map<List<TListModel>>(await _repository.GetAllAsync(c));
    }

    public virtual async Task<TModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        return _mapper.Map<TModel>(await _repository.GetByIdAsync(id, c));
    }

    virtual public async Task<Guid?> UpdateAsync(TModel model, CancellationToken c = default)
    {
        if (! await _repository.ExistsAsync(model.Id, c))
            return null;

        var entity = _mapper.Map<TEntity>(model);
        entity.DateModified = DateTimeOffset.UtcNow;

        return await _repository.UpdateAsync(entity, c);
    }
}

