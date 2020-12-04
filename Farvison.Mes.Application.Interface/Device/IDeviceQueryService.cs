using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Device
{
    public interface IDeviceQueryService
    {
        /// <summary>
        /// 取终端绑定设备
        /// </summary>
        /// <param name="zcNo"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getTerminalDevs(string zcNo, string filter);

        //取所有设备
        BooleanValue<DataTable> getAllSebei(string zcNo);

        //获取换模设备

        BooleanValue<DataTable> getModTerminalDevs(string zcNo, string filter, string modSebeiFilter);

        //取设备产品参数方案
        BooleanValue<DataTable> GetDevPrdParas(string devNo, string zcNo, string prdNo, string tzNo, string moNo, string batNo);

     

        BooleanValue<DataTable> GetDeviceByWorkStationNo(string no);


    }
}
