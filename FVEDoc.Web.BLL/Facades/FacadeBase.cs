using FVEDoc.Common.BL.Facades;

namespace FVEDoc.Web.BLL.Facades;
public class FacadeBase<TDetailModel, TListModel> : IWebFacade
{
    private readonly HttpClient _httpClient;

    public FacadeBase(HttpClient httpClient)
    {
        _httpClient=httpClient;
    }

    public virtual async Task<List<TListModel>> GetAllAsync(CancellationToken c = default)
    {
        return new List<TListModel>();

    }
}

