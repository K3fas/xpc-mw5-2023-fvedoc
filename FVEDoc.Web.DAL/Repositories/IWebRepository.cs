using FVEDoc.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVEDoc.Web.DAL.Repositories;
public interface IWebRepository<TDetailModel, TListModel>
    where TDetailModel : IModelBase
    where TListModel : IModelBase
{

}

