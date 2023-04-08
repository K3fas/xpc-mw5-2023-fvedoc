﻿using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.Battery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class BatteryMapperProfile : Profile
{
    public BatteryMapperProfile()
    {
        CreateMap<BatteryEntity, BatteryModel>();
        CreateMap<BatteryEntity, BatteryListModel>();

        CreateMap<BatteryModel, BatteryEntity>();
    }
}
