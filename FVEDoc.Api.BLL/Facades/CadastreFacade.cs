﻿using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.CadastreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades;
public class CadastreFacade : FacadeBase<CadastreDataEntity, CadastreDataModel>
{
    public CadastreFacade(ICadastreRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

