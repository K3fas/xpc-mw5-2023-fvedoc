using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.PropertyInfo;
using Microsoft.AspNetCore.Mvc;

namespace FVEDoc.Api.App.Controllers;
[ApiController]
[Route("property-info")]
public class PropertyInfoController : BasicController<PropertyInfoEntity, PropertyInfoModel>
{
    public PropertyInfoController(ILogger<PropertyInfoController> logger, IPropertyInfoFacade facade)
        : base(logger, facade)
    {
    }
}
