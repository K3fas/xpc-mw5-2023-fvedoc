﻿using AutoMapper;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.Models.InstallationInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.MapperProfiles;
public class InstallationInfoMapperProfile : MapperBase<InstallationInfoEntity, InstallationInfoModel>
{
    public InstallationInfoMapperProfile()
    {

        //CreateMap<InstallationInfoEntity, InstallationInfoModel>()
        //    .ForMember(dest => dest.InstallationType, act => act.MapFrom(src => src.InstallationType));
        //CreateMap<InstallationInfoModel, InstallationInfoEntity>()
        //    .ForMember(dest => dest.InstallationType, act => act.MapFrom(src => src.InstallationType));

    }
}

