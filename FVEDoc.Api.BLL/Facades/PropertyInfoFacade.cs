using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
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
    public override async Task<Guid?> CreateAsync(PropertyInfoModel model, CancellationToken c = default)
    {
        if (await _repository.ExistsAsync(model.Id))
            return model.Id;

        var entity = _mapper.Map<PropertyInfoEntity>(model);
        entity.DateCreated = DateTimeOffset.UtcNow;

        // Try to insert new cadastre data
        if(model.CadastreData is not null)
        {
            await _cadastreFacade.CreateOrUpdateAsync(model.CadastreData);
        }

        return await _repository.InsertAsync(entity);
    }
}

