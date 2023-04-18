using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Common.BL.Facades;
using FVEDoc.DAL.Common;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

public abstract class BasicController<TEntity, TModel> : ControllerBase, IBasicController<TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    private readonly ILogger _logger;
    protected readonly IFacadeBase<TEntity, TModel> _facade;

    public BasicController(ILogger logger,IFacadeBase<TEntity, TModel> facade)
    {
        _logger=logger;
        _facade=facade;
    }

    [HttpPost("")]
    public virtual IActionResult Create(TModel model)
    {
        _logger.LogInformation("Creating entity {entity}", model.Id);

        try
        {
            return Ok(_facade.Create(model));
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Failed to crate entity !");
            _logger.LogWarning("{ex}", ex.Message);
            return BadRequest();
        }
    }

    [HttpDelete("{id?}")]
    public virtual void Delete(Guid id)
    {
        _logger.LogInformation("Deleting entity {entity}", id);
        _facade.Delete(id);
    }

    [HttpGet("", Order = 0)]
    public virtual IEnumerable<IModelBase> GetAll()
    {
        _logger.LogInformation("Getting all models");
        return (IEnumerable<IModelBase>)_facade.GetAll<TModel>();
    }

    [HttpGet("{id?}")]
    public virtual TModel? GetById(Guid id)
    {
        _logger.LogInformation("Getting model by id {id}",id);
        return _facade.GetById(id);
    }

    [HttpPut("")]
    public virtual Guid? Update(TModel model)
    {
        _logger.LogInformation("Updating entity {entity}", model.Id);
        return _facade.Update(model);
    }
}
