namespace FVEDoc.DAL.Common;
public interface IDbBase
{
    Guid Id { get; init; }
    DateTimeOffset DateCreated { get; init; }
    DateTimeOffset DateModified { get; init; }
}
