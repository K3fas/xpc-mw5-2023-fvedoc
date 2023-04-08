using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.PropertyInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades;
public class PropertyInfoFacade : FacadeBase<PropertyInfoEntity, PropertyInfoModel>
{
    public PropertyInfoFacade(IPropertyInfoRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

