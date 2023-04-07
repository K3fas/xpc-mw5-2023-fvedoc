using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class BatteryRepository : RepositoryBase<BatteryEntity>
{
    public BatteryRepository(Bogus bogus)
        :base(bogus.Batteries)
    {
    }
}

