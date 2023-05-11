using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mock.Repositories;
public class PropertyInfoRepository : RepositoryBase<PropertyInfoEntity>, IPropertyInfoRepository
{
    public PropertyInfoRepository(MockDb bogus)
        : base(bogus.PropertyInfos)
    {
    }
}

