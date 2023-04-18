using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.DAL.Common;

namespace FVEDoc.Common.BL.Facades;
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

    virtual public Guid? Create(TModel model)
    {
        if(_repository.Exists(model.Id))
            return null;

        var entity = _mapper.Map<TEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;

        return _repository.Insert(entity);
    }

    virtual public Guid? CreateOrUpdate(TModel model)
    {
        return _repository.Exists(model.Id)
            ? Update(model)
            : Create(model);
    }

    virtual public Guid? Delete(Guid id)
    {
        if(_repository.Exists(id))
        {
            _repository.Delete(id);
            return id;
        }
        return null;
    }

    public virtual List<TListModel> GetAll<TListModel>() where TListModel : IModelBase
    {
        return _mapper.Map<List<TListModel>>(_repository.GetAll());
    }

    virtual public TModel? GetById(Guid id)
    {
        return _mapper.Map<TModel>(_repository.GetById(id));
    }

    virtual public Guid? Update(TModel model)
    {
        if(! _repository.Exists(model.Id))
            return null;

        var entity = _mapper.Map<TEntity>(model);
        entity.DateModified = DateTimeOffset.UtcNow;

        return _repository.Update(entity);
    }
}

