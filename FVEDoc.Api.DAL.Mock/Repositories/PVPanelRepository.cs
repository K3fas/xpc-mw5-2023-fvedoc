﻿using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class PVPanelRepository : RepositoryBase<PVPanelEntity>, IPVPanelRepository
{
    public PVPanelRepository(BogusSeeder bogus)
        :base(bogus.PVPanels)
    {
    }
}
