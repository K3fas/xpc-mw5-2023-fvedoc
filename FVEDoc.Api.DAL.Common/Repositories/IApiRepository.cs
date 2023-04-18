using FVEDoc.Api.DAL.Common.Entities.Interfaces;

namespace FVEDoc.Api.DAL.Common.Repositories;
public interface IApiRepository<TEntity> where TEntity : IEntity
{
    Task<IList<TEntity>> GetAllAsync(CancellationToken c = default);
    Task<TEntity?> GetByIdAsync(Guid id, CancellationToken c = default);
    Task<Guid> InsertAsync(TEntity entity, CancellationToken c = default);
    Task<Guid> UpdateAsync(TEntity entity, CancellationToken c = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken c = default);
    Task<bool> ExistsAsync(Guid id, CancellationToken c = default);
}
