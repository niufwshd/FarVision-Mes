using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Production.TraceBack
{
    public interface ITraceBackService
    {
        /// <summary>
        /// 正向追溯工序层级数据获取
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="curZCNO"></param>
        /// <param name="idNo"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getFwTraceProcess(string barCode,string curZCNO,string idNo);
    }
}
