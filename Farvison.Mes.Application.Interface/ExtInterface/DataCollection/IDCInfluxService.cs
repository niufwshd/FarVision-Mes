using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.Trace;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.ExtInterface.DataCollection
{
    /// <summary>
    /// 数采时序库接口服务
    /// </summary>
    public interface IDCInfluxService
    {
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="dmCode"></param>
        /// <returns></returns>
        Task<BooleanValue<string>> WriteData(ProcessParametes ppModel);

   
    }
}
