using FVEDoc.Api.DAL.Common.Entities.Interfaces;

namespace FVEDoc.Api.DAL.Common.Repositories;
public abstract class RepositoryBase<T> : IApiRepository<T> where T : class, IEntity
{
    private readonly IList<T> _entities;

    public RepositoryBase(IList<T> entities)
    {
        _entities = entities;
    }
    public async Task<bool> DeleteAsync(Guid id, CancellationToken c = default)
    {
        var toRemove = await GetByIdAsync(id);
        if (toRemove != null)
        {
            _entities.Remove(toRemove);
            return true;
        }
        return false;
    }

    public async Task<bool> ExistsAsync(Guid id, CancellationToken c = default)
    {
        return _entities.Select(x => x.Id).Contains(id);
    }

    public async Task<IList<T>> GetAllAsync(CancellationToken c = default)
    {
        return _entities;
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        return await ExistsAsync(id, c)
            ? _entities.FirstOrDefault(x => x.Id == id)
            : null;
    }

    public async Task<Guid> InsertAsync(T entity, CancellationToken c = default)
    {
        _entities.Add(entity);
        return entity.Id;
    }


    public async Task<Guid> UpdateAsync(T entity, CancellationToken c = default)
    {
        var toUpdate = await GetByIdAsync(entity.Id);
        if (toUpdate != null)
        {
            _entities.Remove(toUpdate);
            _entities.Add(entity);
        }
        return entity.Id;
    }
}

