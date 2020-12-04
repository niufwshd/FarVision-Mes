using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebMES.DTO.PAD;
using WebMES.DTO.PostBack;
using WebMES.Model.Production.ProductionPlan;
using WebMES.Model.WareHouse;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Production.Plan
{
    public interface IProductPlanService
    {
        /// <summary>
        /// 手动排产，来源为MO单
        /// </summary>
        /// <param name="schedModel"></param>
        /// <returns></returns>
        BooleanResult ManualScheduling(SchedulingModel schedModel);

        /// <summary>
        /// 批量手动排产，无工单变更
        /// </summary>
        /// <param name="schedModelList"></param>
        /// <returns></returns>
        BooleanResult BatchManualSchedulingNoChange(List<SchedulingModel> schedModelList);

        /// <summary>
        /// 批量排产导入，有工单变更
        /// </summary>
        /// <param name="schedModels"></param>
        /// <returns></returns>

        BooleanResult ManualSchedulingBatch(List<SchedulingModel> schedModels);
        /// <summary>
        /// 排产工单修改，删除
        /// </summary>
        /// <param name="lstBDOs"></param>
        /// <returns></returns>
        BooleanResult SchedulingChange(List<BDOs> lstBDOs);

        /// <summary>
        /// 取已排产信息
        /// </summary>
        /// <param name="moNo"></param>
        /// <param name="layoutNo"></param>
        /// <param name="dtStart"></param>
        /// <param name="dtEnd"></param>
        /// <returns></returns>
       BooleanValue<DataTable> GetSchedHistory(string wkCenterNo, DateTime dtStart);

       BooleanValue<DataTable> GetSchedHistory(DateTime schedDate, List<string> layoutNos);
        /// <summary>
        /// 生产工单变更
        /// </summary>
        /// <param name="bdosChange">变更单业务信息</param>
        /// <param name="UpdateSql">返回更新sql</param>
        /// <returns></returns>
        BooleanValue<BDOs> ChangeWorkOrderInfo(BDOs bdosChange, out BDOs bdosMatPlan,out string UpdateSql);

        /// <summary>
        /// 工单是否可以变更
        /// </summary>
        /// <param name="ChkItem">变更项目信息</param>
        /// <param name="OldOrderRow">原工单行信息</param>
        /// <returns></returns>
        BooleanValue<List<string>> IsOrderCanChange(OrderChangeItemModel ChkItem, DataRow OldOrderRow);


        /// <summary>
        /// 生产订单是否可以变更
        /// </summary>
        /// <param name="ChkItem">变更项目信息</param>
        /// <param name="OldOrderRow">原订单行信息</param>
        /// <returns></returns>
        BooleanValue<List<string>> IsProductOrderCanChange(OrderChangeItemModel ChkItem, DataRow OldOrderRow);

        /// <summary>
        /// 获取工单备料列表信息
        /// </summary>
        /// <param name="orderNoList">工单号列表</param>
        /// <returns></returns>
        BooleanValue<List<MaterialPreparaPlanItemModel>> GetOrderMaterials(List<string> orderNoList);

        /// <summary>
        /// 变更单生成
        /// </summary>
        /// <param name="oldOrderRow">原变更的工单信息</param>
        /// <param name="changeItem">变更信息</param>
        /// <param name="changeRemark">变更备注-变更单表头用</param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateOrderChangeInfo(DataRow oldOrderRow, OrderChangeItemModel changeItem, string changeRemark);

        /// <summary>
        /// 工单下发到接口，如果有
        /// </summary>
        /// <param name="bdosOrders">工单BDOs</param>
        /// <returns></returns>
        BooleanResult OrderIssued(BDOs bdosOrders);
    }
}
