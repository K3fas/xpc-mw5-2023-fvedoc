﻿using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.InstallationInfo;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface IInstallationInfoFacade : IFacadeBase<InstallationInfoEntity, InstallationInfoModel>, IApiFacade
{
}

