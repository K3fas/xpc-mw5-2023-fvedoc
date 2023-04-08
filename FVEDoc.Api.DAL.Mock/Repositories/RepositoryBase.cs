using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Repositories;
public abstract class RepositoryBase<T> : IApiRepository<T> where T : IEntity
{
    private readonly IList<T> _entities;

    public RepositoryBase(IList<T> entities)
    {
        _entities = entities;
    }
    public void Delete(Guid id)
    {
        var toRemove = GetById(id);
        if(toRemove != null)
        {
            _entities.Remove(toRemove);
        }
    }

    public bool Exists(Guid id)
    {
        if(_entities.Select(x => x.Id).Contains(id))
        {
            return true;
        }
        return false;
    }

    public IList<T> GetAll()
    {
        return _entities;
    }

    public T? GetById(Guid id)
    {
        return _entities.FirstOrDefault(x => x.Id == id);
    }

    public Guid Insert(T entity)
    {
        _entities.Add(entity);
        return entity.Id;
    }

    public Guid Update(T entity)
    {
        var toUpdate = GetById(entity.Id);
        if(toUpdate != null)
        {
            _entities.Remove(toUpdate);
            _entities.Add(entity);
        }
        return entity.Id;
    }
}

