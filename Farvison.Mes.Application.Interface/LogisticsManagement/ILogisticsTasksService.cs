using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.WareHouse;
using System.Linq.Expressions;
using WebMES.Model.LogisticsManagement;
using WebMES.Model.Data;

namespace WebMES.Service.Interface.LogisticsManagement 
{
    public interface ILogisticsTasksService
    {
        /// <summary>
        /// 创建物流任务单
        /// </summary>
        /// <param name="outformModel"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateLogisticsTasks(LogisticsTasksModel model);

        /// <summary>
        /// 修改物流任务单状态
        /// </summary>
        /// <param name="no"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateLogisticsTasksStatus(string no, string status);


        /// <summary>
        /// 接受/分配物流任务单（变更任务承运人及单据状态）
        /// </summary>
        /// <param name="no"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateLogisticsTasksCarrier(string no, string carrier);

        /// <summary>
        /// 撤销任务单
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> CancelLogisticsTasks(string NO);


        /// <summary>
        /// 完成任务单
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> FinishLogisticsTasks(string NO, string Location);

        /// <summary>
        /// 完成物流任务
        /// </summary>
        /// <param name="model"></param>
        /// <param name="Location"></param>
        /// <returns></returns>
        BooleanValue<BDOs> FinishLogisticsTasks(LogisticsTasksModel model, string Location);

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="leLogistics"></param>
        /// <param name="operate"></param>
        /// <returns></returns>
        BooleanValue<BDOs> SaveHistory(BooleanValue<BDOs> leLogistics, string operate);


        /// <summary>
        /// 任务单配送
        /// </summary>
        /// <param name="NO"></param>
        /// <returns></returns>
        BooleanValue<BDOs> StartDeliveryLogisticsTasks(string NO);


        /// <summary>
        /// 修改物流任务完成数量
        /// </summary>
        /// <param name="ID"> 物流任务行项目ID</param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateLogisticsTaskItemQuantity(string ID, decimal Quantity);

        /// <summary>
        /// 获取物流单打印文本
        /// </summary>
        /// <param name="NO"></param>
        /// <returns></returns>
        ResponseStatusModel<string> GetLogisticsTaskPrintMessage(string NO);


        /// <summary>
        /// 物流调度计划
        /// 拣料单工单发生变更 修改原拣料单 计划跟完成数量 新增到目标工单-（目的仓库）的拣料单 并且发起原工单的的备料计划请求
        /// </summary>
        /// <param name="PMID"></param>
        /// <param name="WO_NO"></param>
        /// <param name="TargetWareHouse"></param>
        /// <param name="Quantity"></param>
        void LogisticsSchedulingPlan(LogisticsSchedulingModel model,out string NewPickMaterialID);

        /// <summary>
        /// 根据物流调度获取物流任务
        /// </summary>
        /// <returns></returns>
        List<LogisticsTasksModel> GetLogisticsTasks();

      

        /// <summary>
        /// 创建物流任务
        /// </summary>
        /// <param name="tmpLTM"></param>
        void AddLogisticsTask(LogisticsTasksModel tmpLTM);


        /// <summary>
        ///  部分完成的 修改为指定完成  并修改来源单据的发运数量   
        ///  发运中的 单据修改为 取消 并修改来源单据的发运数量
        /// </summary>
        /// <param name="NO"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CloseLogisticsTasks(string NO);
    }
}
