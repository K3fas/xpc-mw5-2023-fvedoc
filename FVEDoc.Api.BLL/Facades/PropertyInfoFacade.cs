using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Models.PropertyInfo;

namespace FVEDoc.Api.BLL.Facades;
public class PropertyInfoFacade : FacadeBase<PropertyInfoEntity, PropertyInfoModel>, IPropertyInfoFacade
{
    private readonly ICadastreFacade _cadastreFacade;

    public PropertyInfoFacade(IPropertyInfoRepository repository, ICadastreFacade cadastreFacade, IMapper mapper)
        : base(repository, mapper)
    {
        _cadastreFacade=cadastreFacade;
    }

    public override async Task<PropertyInfoModel?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        var entity = await _repository.GetByIdAsync(id, c);
        if (entity is null)
            return null;

        var model = _mapper.Map<PropertyInfoModel>(entity);
        model.CadastreData = await _cadastreFacade.GetByIdAsync(entity.CadastreData.GetValueOrDefault(), c);

        return model;
    }

}

