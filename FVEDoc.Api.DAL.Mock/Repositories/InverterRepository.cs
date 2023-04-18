using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class InverterRepository : RepositoryBase<InverterEntity>, IInverterRepository
{
    public InverterRepository(MockDb bogus)
        :base(bogus.Inverters)
    {
    }
}

