﻿

using FVEDoc.Common.Models;

namespace FVEDoc.Api.DAL.Common.Entities.Interfaces;
public interface IEntity : IModelBase
{
    DateTimeOffset DateCreated { get; set; }
    DateTimeOffset DateModified { get; set; }
}
