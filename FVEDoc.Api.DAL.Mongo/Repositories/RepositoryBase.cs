using FVEDoc.Api.DAL.Common.Entities.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FVEDoc.Api.DAL.Common.Repositories;
public abstract class RepositoryBase<T> : IApiRepository<T> where T : class, IEntity
{
    protected readonly IMongoCollection<T> _collection;

    public RepositoryBase(IMongoCollection<T> collection)
    {
        _collection = collection;
    }

    public virtual async Task<bool> DeleteAsync(Guid id, CancellationToken c = default)
    {
        var filter = Builders<T>.Filter.Eq(x => x.Id, id);
        var result = await _collection.DeleteOneAsync(filter, c);
        return result.DeletedCount > 0;
    }

    public virtual async Task<bool> ExistsAsync(Guid id, CancellationToken c = default)
    {
        var filter = Builders<T>.Filter.Eq(x => x.Id, id);
        var result = await _collection.CountDocumentsAsync(filter, cancellationToken: c);
        return result > 0;
    }

    public virtual async Task<IList<T>> GetAllAsync(CancellationToken c = default)
    {
        try
        {
            var cursor = await _collection.FindAsync(new BsonDocument(), cancellationToken: c);
            return await cursor.ToListAsync(c);
        }
        catch (Exception ex)
        {

            throw;
        }
    }

    public virtual async Task<T?> GetByIdAsync(Guid id, CancellationToken c = default)
    {
        var filter = Builders<T>.Filter.Eq(x => x.Id, id);
        var cursor = await _collection.FindAsync(filter, cancellationToken: c);
        return await cursor.FirstOrDefaultAsync(c);
     }

    public virtual async Task<Guid> InsertAsync(T entity, CancellationToken c = default)
    {
        _collection.InsertOne(entity, cancellationToken: c);
        return entity.Id;
    }

    public virtual async Task<Guid> UpdateAsync(T entity, CancellationToken c = default)
    {
        var filter = Builders<T>.Filter.Eq(x => x.Id, entity.Id);
        var result = await _collection.FindOneAndReplaceAsync(filter, entity, cancellationToken: c);
        return result.Id;
    }
}

