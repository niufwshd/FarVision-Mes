using YueMES.Base.Utils;
using WebMES.Model.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Production.Orders
{
    public interface IOrderService
    {
        /// <summary>
        /// 根据给定的排产工单，生成指定工序的工单，设备字段不写
        /// </summary>
        /// <param name="oderModel"></param>
        /// <returns></returns>
        BooleanValue<string> createUnSchedulingOrders(OrderModel orderModel);

        /// <summary>
        /// 工单状态更新
        /// </summary>
        /// <param name="OrderNo">工单号</param>
        /// <param name="status">1:工单的初始状态
        ///                      2:从原材料仓移到线边算领料
        ///                      3:生产中:首工序投料后就变更为生产中
        ///                      4:对生产中的工单暂停
        ///                      5:已完工:达到工单计划产量关闭工单
        ///                      6:未生产的工单取消
        ///                      7:指定完工:有投产但未达到生产工单产量关闭</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateOrderStatus(string OrderNo, string status);

    }
}
