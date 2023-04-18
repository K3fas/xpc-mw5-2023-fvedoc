using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.PropertyInfo;
using System.Runtime.CompilerServices;

namespace FVEDoc.Api.BLL.Facades;
public class PropertyInfoFacade : FacadeBase<PropertyInfoEntity, PropertyInfoModel>, IPropertyInfoFacade
{
    private readonly ICadastreFacade _cadastreFacade;

    public PropertyInfoFacade(IPropertyInfoRepository repository, ICadastreFacade cadastreFacade, IMapper mapper)
        : base(repository, mapper)
    {
        _cadastreFacade=cadastreFacade;
    }
    public override Guid? Create(PropertyInfoModel model)
    {
        if (_repository.Exists(model.Id))
            return model.Id;

        var entity = _mapper.Map<PropertyInfoEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;

        // Try to insert new cadastre data
        if(model.CadastreData is not null)
        {
            _cadastreFacade.CreateOrUpdate(model.CadastreData);
        }

        return _repository.Insert(entity);
    }
}

