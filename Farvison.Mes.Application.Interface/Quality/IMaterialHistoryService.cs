using YueMES.Base.Utils;
using WebMES.Model.Quality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Quality
{
    public interface IMaterialHistoryService
    {
        BooleanResult deleteMaterialHistory(MaterialHistory materialHistory);

        BooleanResult deleteProductionFeedRLHistory(MaterialHistory materialHistory);

    }
}
