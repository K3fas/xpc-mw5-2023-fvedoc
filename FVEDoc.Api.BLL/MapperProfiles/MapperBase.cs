using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Common.Models;

namespace FVEDoc.Api.BLL.MapperProfiles;
public abstract class MapperBase<TEntity, TModel> : Profile , IMapperBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    public MapperBase()
    {
        CreateMap<TEntity, TModel>();
        CreateMap<TModel, TEntity>()
            .ForMember(dest => dest.DateCreated, src => src.Ignore())
            .ForMember(dest => dest.DateModified, src => src.Ignore());

    }
}

