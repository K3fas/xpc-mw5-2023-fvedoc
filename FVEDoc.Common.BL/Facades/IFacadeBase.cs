using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.DAL.Common;

namespace FVEDoc.Common.BL.Facades;
public interface IFacadeBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    Task<List<TListModel>> GetAllAsync<TListModel>(CancellationToken c = default) where TListModel : IModelBase;
    Task<TModel?> GetByIdAsync(Guid id, CancellationToken c = default);
    Task<Guid?> CreateOrUpdateAsync(TModel model, CancellationToken c = default);
    Task<Guid?> CreateAsync(TModel model, CancellationToken c = default);
    Task<Guid?> UpdateAsync(TModel model, CancellationToken c = default);
    Task<Guid?> DeleteAsync(Guid id, CancellationToken c = default);
}

