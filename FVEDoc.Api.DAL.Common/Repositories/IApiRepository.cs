using FVEDoc.Api.DAL.Common.Entities.Interfaces;

namespace FVEDoc.Api.DAL.Common.Repositories;
public interface IApiRepository<TEntity> where TEntity : IEntity
{
    IList<TEntity> GetAll();
    TEntity? GetById(Guid id);
    Guid Insert(TEntity entity);
    Guid Update(TEntity entity);
    void Delete(Guid id);
    bool Exists(Guid id);
}
