using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Common.Repositories;

namespace FVEDoc.Api.DAL.Mongo.Repositories;
public class PropertyInfoRepository : RepositoryBase<PropertyInfoEntity>, IPropertyInfoRepository
{
    public PropertyInfoRepository(MongoDbContext mongo)
        :base(mongo.GetCollection<PropertyInfoEntity>("property-info"))
    {
    }
}

