using FVEDoc.DAL.Common;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

public interface IBasicController<TModel> where TModel : IModelBase
{
    [HttpGet]
    [Route("all")]
    public IEnumerable<TModel> GetAll();

    [HttpGet]
    [Route("{id?}")]
    public TModel? GetById(Guid id);

    [HttpPost]
    [Route("create")]
    public IActionResult? Create(TModel model);

    [HttpDelete]
    [Route("delete/{id?}")]
    public void Delete(Guid id);

    [HttpPut]
    [Route("update")]
    public Guid? Update(TModel model);
}
