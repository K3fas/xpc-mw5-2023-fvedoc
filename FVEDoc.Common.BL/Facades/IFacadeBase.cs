using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.DAL.Common;

namespace FVEDoc.Common.BL.Facades;
public interface IFacadeBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    List<TModel> GetAll();
    TModel? GetById(Guid id);
    Guid CreateOrUpdate(TModel model);
    Guid Create(TModel model);
    Guid Update(TModel model);
    void Delete(Guid id);
}

