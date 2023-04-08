using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Common.BL.Facades;
using FVEDoc.Common.Models.Battery;
using FVEDoc.Common.Models.InstallationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.BLL.Facades.Interfaces;
public interface IInstalaltionTypeFacade : IFacadeBase<InstallationTypeEntity, InstallationTypeModel>, IApiFacade
{
}

