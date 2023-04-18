using FVEDoc.DAL.Common;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

public interface IBasicController<TModel> where TModel : IModelBase
{
    public Task<Results<BadRequest, Created<Guid>>> CreateAsync(TModel model);
    public Task<Results<NoContent, Ok<IEnumerable<IModelBase>>>> GetAllAsync();
    public Task<Results<NotFound, Ok<TModel>>> GetByIdAsync(Guid id);
    public Task<Results<BadRequest, Ok<Guid>>> UpdateAsync(TModel model);
    public Task<Results<NotFound, Ok<Guid>>> DeleteAsync(Guid id);
}
