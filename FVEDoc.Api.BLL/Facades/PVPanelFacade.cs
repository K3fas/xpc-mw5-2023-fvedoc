using AutoMapper;
using FVEDoc.Api.BLL.Facades.Interfaces;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.PVPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades;
public class PVPanelFacade : FacadeBase<PVPanelEntity, PVPanelModel>, IPVPanelFacade
{
    public PVPanelFacade(IPVPanelRepository repository, IMapper mapper)
        : base(repository, mapper)
    {

    }
}

