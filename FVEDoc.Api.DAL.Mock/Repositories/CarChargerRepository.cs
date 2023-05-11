using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class CarChargerRepository : RepositoryBase<CarChargerEntity>, ICarChargerRepository
{
    public CarChargerRepository(MockDb bogus)
        : base(bogus.CarChargers)
    {
    }
}

