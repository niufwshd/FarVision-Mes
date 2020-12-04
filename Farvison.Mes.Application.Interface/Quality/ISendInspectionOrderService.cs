using System;
using System.Collections.Generic;
using System.Text;
using WebMES.DTO.PostBack;
using WebMES.Model.Quality;
using WebMES.Model.WareHouse;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Quality
{
    /// <summary>
    /// 送检单接口
    /// </summary>
    public interface ISendInspectionOrderService
    {

        /// <summary>
        /// 转单
        /// </summary>
        /// <param name="id">表身id</param>
        /// <returns></returns>
        BooleanResult TransferOfOrder(BDOs bDOs);

        /// <summary>
        /// 创建送检单
        /// </summary>
        /// <param name="sendInspectingOrders">送检单集合</param>
        /// <returns></returns>
        BooleanResult CreateSendInspectionOrder(List<SendInspectionOrder> sendInspectingOrders);

        /// <summary>
        /// 生成检验结果 如果存在，修改检验值
        /// </summary>
        /// <param name="sendInspectingOrders"></param>
        /// <returns></returns>
        BooleanValue<BDOs> GenerateInspectionRecord(InspectionRecord model);

        /// <summary>
        /// 检查送检单是否完成，不存在的话 默认完成
        /// </summary>
        /// <param name="Source_no"></param>
        /// <returns></returns>
        bool CheckInspectonResult(string Source_no);

        BooleanResult CreateSendInspectionOrder_XL(List<SendInspectionOrder> sendInspectingOrders);

    }
}
