using FVEDoc.Common.Models;

namespace FVEDoc.Web.DAL.Repositories;
public interface IWebRepository<TDetailModel, TListModel>
    where TDetailModel : IModelBase
    where TListModel : IModelBase
{

}

