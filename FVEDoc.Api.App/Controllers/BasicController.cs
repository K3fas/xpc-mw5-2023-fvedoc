using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using FVEDoc.Common.BL.Facades;
using FVEDoc.DAL.Common;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Reflection;

namespace FVEDoc.Api.App.Controllers;

public abstract class BasicController<TEntity, TModel> : ControllerBase, IBasicController<TModel>
    where TEntity : IEntity
    where TModel : IModelBase
{
    private readonly ILogger _logger;
    protected readonly IFacadeBase<TEntity, TModel> _facade;

    public BasicController(ILogger logger, IFacadeBase<TEntity, TModel> facade)
    {
        _logger=logger;
        _facade=facade;
    }

    [HttpPost("", Order = 1)]
    [SwaggerResponse(StatusCodes.Status201Created)]
    [SwaggerResponse(StatusCodes.Status400BadRequest)]
    public virtual async Task<Results<BadRequest, Created<Guid>>> CreateAsync(TModel model)
    {
        _logger.LogInformation("Creating entity {entity}", model.Id);

        try
        {
            var id = _facade.Create(model);
            var location = $"/{model.Id}";
            return id is null ? TypedResults.BadRequest() : TypedResults.Created(location ?? "", id.GetValueOrDefault());
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Failed to create entity !");
            _logger.LogWarning("{ex}", ex.Message);
            return TypedResults.BadRequest();
        }
    }

    [HttpGet("", Order = 1)]
    [SwaggerResponse(StatusCodes.Status200OK)]
    [SwaggerResponse(StatusCodes.Status204NoContent)]
    public virtual async Task<Results<NoContent, Ok<IEnumerable<IModelBase>>>> GetAllAsync()
    {
        _logger.LogInformation("Getting all models");
        try
        {
            var list = (IEnumerable<IModelBase>)_facade.GetAll<TModel>();
            return list.Any() ? TypedResults.Ok(list) : TypedResults.NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Method GetAllAsync failed");
            Console.WriteLine(ex.Message);
            return TypedResults.NoContent();
        }

    }

    [HttpGet("{id?}", Order = 1)]
    [SwaggerResponse(StatusCodes.Status200OK)]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public virtual async Task<Results<NotFound, Ok<TModel>>> GetByIdAsync(Guid id)
    {
        _logger.LogInformation("Getting model by id {id}", id);
        try
        {
            var model = _facade.GetById(id);
            return model is null ? TypedResults.NotFound() : TypedResults.Ok(model);
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Method GetByIdAsync failed");
            Console.WriteLine(ex.Message);
            return TypedResults.NotFound();
        }

    }

    [HttpPut("", Order = 1)]
    [SwaggerResponse(StatusCodes.Status200OK)]
    [SwaggerResponse(StatusCodes.Status400BadRequest)]
    public virtual async Task<Results<BadRequest, Ok<Guid>>> UpdateAsync(TModel model)
    {
        _logger.LogInformation("Updating entity {entity}", model.Id);
        try
        {
            var id = _facade.CreateOrUpdate(model);
            return id is null ? TypedResults.BadRequest() : TypedResults.Ok(id.GetValueOrDefault());

        }
        catch (Exception ex)
        {
            _logger.LogWarning("Method UpdateAsync failed");
            Console.WriteLine(ex.Message);
            return TypedResults.BadRequest();
        }

    }

    [HttpDelete("{id?}", Order = 1)]
    [SwaggerResponse(StatusCodes.Status200OK)]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public virtual async Task<Results<NotFound, Ok<Guid>>> DeleteAsync(Guid id)
    {
        _logger.LogInformation("Deleting entity {entity}", id);
        try
        {
            var found = _facade.Delete(id);
            return found is null ? TypedResults.NotFound() : TypedResults.Ok(id);

        }
        catch (Exception ex)
        {
            _logger.LogWarning("Method DeleteAsync failed");
            Console.WriteLine(ex.Message);
            return TypedResults.NotFound();
        }
    }
}
