using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Common.Models;

namespace FVEDoc.Api.BLL.MapperProfiles;
public interface IMapperBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
}

