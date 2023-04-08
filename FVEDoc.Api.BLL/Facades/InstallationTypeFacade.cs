﻿using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.InstallationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades;
public class InstallationTypeFacade : FacadeBase<InstallationTypeEntity, InstallationTypeModel>, IInstallationTypeFacade
{
    public InstallationTypeFacade(IInstallationTypeRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

