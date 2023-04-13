using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.PropertyInfo;

namespace FVEDoc.Api.BLL.Facades;
public class PropertyInfoFacade : FacadeBase<PropertyInfoEntity, PropertyInfoModel>, IPropertyInfoFacade
{
    public PropertyInfoFacade(IPropertyInfoRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

