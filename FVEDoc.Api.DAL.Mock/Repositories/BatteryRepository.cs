using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class BatteryRepository : RepositoryBase<BatteryEntity>, IBatteryRepository
{
    public BatteryRepository(BogusSeeder bogus)
        :base(bogus.Batteries)
    {
    }
}

