using FVEDoc.DAL.Common;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;

public interface IBasicController<TModel> where TModel : IModelBase
{
    public IEnumerable<IModelBase> GetAll();

    public TModel? GetById(Guid id);

    public IActionResult? Create(TModel model);

    public void Delete(Guid id);

    public Guid? Update(TModel model);
}
