using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.PRDT
{
   public interface IOnTrayService
    {
        /// <summary>
        /// 根据条件获取当班未装托数(上班+本班报工数量 - 上班+本班已装托数量)
        /// </summary>
        /// <param name="ZC_N0"></param>
        /// <param name="SEB_NO"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getOnLoadingQty(string ZC_N0,string SEB_NO,DateTime startDate, DateTime endDate );



        /// <summary>
        /// 建托盘条码信息
        /// </summary>
        /// <param name="tzInfo"></param>
        /// <returns></returns>
        BooleanValue<BDO> CreatePalletcode(dynamic ontrayInfo);

        /// <summary>
        /// 建托盘信息
        /// </summary>
        /// <param name="tzInfo"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreatePageAge(dynamic ontrayInfo);


        /// <summary>
        /// 追溯二级信息
        /// </summary>
        /// <param name="tzInfo"></param>
        /// <returns></returns>
        BooleanValue<BDO> CreateTraceabilityLog(dynamic ontrayInfo);


        /// <summary>
        /// 库存
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateStorAge(dynamic ontrayinfo);


        BooleanValue<BDOs> CreateEnterForm(dynamic ontrayinfo);



        List<BooleanValue<BDOs>> CreatePackageFeed(dynamic Info);


        //向U9 发送报工结果
        BooleanResult SendWorkReportToU9(dynamic workInfo, dynamic ontrayInfo);


        //向U9 发送报工标识
        BooleanResult SendWorkReportToU9PlanWorkStart(dynamic workInfo);


        //向U9 发送退料信息
        BooleanResult SendRejectedMaterialToU9(dynamic Info);

        //向U9 发送出货信息
        BooleanResult SendExWareHouseToU9(dynamic Info);

        //向U9 发送调拨信息
        BooleanResult TransfersToU9(dynamic TransfersInfo);


    }
}
