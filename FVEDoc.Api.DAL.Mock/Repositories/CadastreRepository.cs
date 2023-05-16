using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class CadastreRepository : RepositoryBase<CadastreDataEntity>, ICadastreRepository
{
    public CadastreRepository(MockDb bogus)
        : base(bogus.CadastreData)
    {
    }
}

