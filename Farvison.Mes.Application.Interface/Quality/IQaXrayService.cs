using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.Quality;

namespace WebMES.Service.Interface.Quality
{
   public interface IQaXrayService
    {
       /// <summary>
       /// 根据条件获取数采数据。
       /// </summary>
       /// <param name="PRD_NO">产品编号</param>
       /// <param name="MOD_N0">模具编号</param>
       /// <param name="SEB_NO">设备编号</param>
       /// <returns></returns>
        BooleanValue<DataTable> GetCAMERA(string PRD_NO, string MOD_N0, string SEB_NO);
         
    }
}
