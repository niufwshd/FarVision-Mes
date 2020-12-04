using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.PRDT
{
   public interface IMKYGPRDTService
    {
        /// <summary>
        /// 根据条件获取报工品名
        /// </summary>
        /// <param name="ZC_N0"></param>
        /// <param name="SEB_NO"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getPRDT(string ZC_N0,string SEB_NO,DateTime NowDate,string NowBanNo, DateTime LastDate, string LastBanNo );

        /// <summary>
        /// 获取低压铸造机工序的报工产品
        /// </summary>
        /// <param name="ZC_N0"></param>
        /// <param name="SEB_NO"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getAllPRDT(DateTime startDate, DateTime endDate);




    }
}
