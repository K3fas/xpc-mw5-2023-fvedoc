using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Common.Repositories;
public abstract class RepositoryBase<T> : IApiRepository<T> where T : class, IEntity
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
        return _entities.Select(x => x.Id).Contains(id);
    }

    public IList<T> GetAll()
    {
        return _entities;
    }

    public T? GetById(Guid id)
    {
        return Exists(id)
            ? _entities.FirstOrDefault(x => x.Id == id)
            : null;
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

