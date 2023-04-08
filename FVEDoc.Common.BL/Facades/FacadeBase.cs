﻿using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Common.BL.Facades;
public abstract class FacadeBase<TEntity, TModel> : IFacadeBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IWithId
{
    protected readonly IApiRepository<TEntity> _repository;
    protected readonly IMapper _mapper;

    public FacadeBase(IApiRepository<TEntity> repository, IMapper mapper)
    {
        _repository=repository;
        _mapper=mapper;
    }

    public Guid Create(TModel model)
    {
        var entity = _mapper.Map<TEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;
        entity.DateModified = DateTimeOffset.UtcNow;

        return _repository.Insert(entity);
    }

    public Guid CreateOrUpdate(TModel model)
    {
        return _repository.Exists(model.Id)
            ? Update(model)!.Value
            : Create(model);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public List<TModel> GetAll()
    {
        return _mapper.Map<List<TModel>>(_repository.GetAll());
    }

    public TModel? GetById(Guid id)
    {
        return _mapper.Map<TModel>(_repository.GetById(id));
    }

    public Guid? Update(TModel model)
    {
        var entity = _mapper.Map<TEntity>(model);
        entity.DateModified = DateTimeOffset.UtcNow;

        return _repository.Update(entity);
    }
}
