using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.DAL.Common;

namespace FVEDoc.Api.BLL.MapperProfiles;
public interface IMapperBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
}

