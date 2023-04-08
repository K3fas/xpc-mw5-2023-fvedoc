using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.MapperProfiles;
public abstract class MapperBase<TEntity, TModel> : Profile , IMapperBase<TEntity, TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    public MapperBase()
    {
        CreateMap<TEntity, TModel>();
        CreateMap<TModel, TEntity>();
    }
}

