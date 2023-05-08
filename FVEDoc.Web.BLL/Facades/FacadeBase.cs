using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models;
using FVEDoc.Web.DAL.Repositories;
using Microsoft.Extensions.Logging;

namespace FVEDoc.Web.BLL.Facades;
public class FacadeBase<TDetailModel, TListModel>: IWebFacade
    where TDetailModel : IModelBase
    where TListModel : IModelBase
{
    private readonly RepositoryBase<TDetailModel, TListModel> _repo;
    private readonly ILogger _logger;

    public FacadeBase(RepositoryBase<TDetailModel, TListModel> repo, ILogger logger)
    {
        _repo=repo;
        _logger=logger;
    }

    public async Task<Guid> CreateAsync(TDetailModel model)
    {
        try
        {
            return await _repo.CreateAsync(model);
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Falied to create model {name} with id {id}", typeof(TDetailModel), model.Id);
            _logger.LogWarning("Message: {msg}",ex.Message);
            throw;
        }
    }

    public async Task<List<TListModel>?> GetAllAsync()
    {
        try
        {
            return await _repo.GetAllAsync();
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Failed to get all models {name}", nameof(TListModel));
            _logger.LogWarning("Message: ", ex.Message);

            throw;
        }
    }

    public async Task<TDetailModel?> GetByIdAsync(Guid id)
    {
        try
        {
            return await _repo.GetByIdAsync(id);
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Failed to get model {name} by id {id}", nameof(TDetailModel), id);
            _logger.LogWarning("Message: {msg}", ex.Message);
            throw;
        }
    }

    public async Task<Guid> UpdateAsync(TDetailModel model)
    {
        try
        {
            return await _repo.UpdateAsync(model);
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Failed to update model {name} with id {id}", nameof(TDetailModel), model.Id);
            _logger.LogWarning("Message: ", ex.Message);

            throw;
        }
    }

    public async Task<Guid> DeleteAsync(Guid id)
    {
        try
        {
            return await _repo.DeleteAsync(id);
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Failed to delete model {name} with id {id}", nameof(TDetailModel), id);
            _logger.LogWarning("Message: ", ex.Message);
            throw;
        }
    }



}

