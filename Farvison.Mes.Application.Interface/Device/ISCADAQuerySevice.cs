using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebMES.DTO.Filter;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.Device
{
    public interface ISCADAQuerySevice
    {
        //取设备数采数据
        Task<BooleanValue<DataTable>> GetDevPrdParas(string TraceCode, string ProcessNo);

        //取设备数采数据
        Task<BooleanValue<DataTable>> GetDevPrdParas(string TraceCode);

        //取设备数采数据
        Task<BooleanValue<DataTable>> GetDevPrdParas(List<string> TraceCodeList);

        /// <summary>
        /// 取设备数采参数，不转成行
        /// </summary>
        /// <param name="queryNo"></param>
        /// <param name="filterCustom"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetDevPrdParas(string queryNo, List<FilterCustomDTO> filterCustom);
    }
}
