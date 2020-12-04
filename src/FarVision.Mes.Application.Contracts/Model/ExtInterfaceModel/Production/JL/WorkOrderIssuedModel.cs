using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ExtInterfaceModel.Production.JL
{
    /// <summary>
    /// 工单下发
    /// </summary>
    public class WorkOrderIssuedModel
    {
        public WorkOrderIssuedModel()
        {
            //ID = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            IsProcessed = 0;
            Flag = "true";
        }
        /// <summary>
        /// 记录惟一标识号
        /// </summary>
      //  public string ID { get; private set; }

        /// <summary>
        /// 布局编号（工位编号）
        /// </summary>
        public string Layout_No { get; set; }
        /// <summary>
        /// 当前正在作业工单号
        /// </summary>
        public string WO_No { get; set; }

        /// <summary>
        /// 当前工单对应工序
        /// </summary>
        public string Process_No { get; set; }
        
        /// <summary>
        /// 产品料号（物料编码）
        /// </summary>
        public string Prod_No { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Prod_Name { get; set; }
        /// <summary>
        /// 图号
        /// </summary>
        public string FigureNo { get; set; }
        /// <summary>
        /// 历史图号
        /// </summary>
        public string DrawNo_His { get; set; }
        /// <summary>
        /// 工单计划数量
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 计划上线时间（预计开工时间）
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 计划下线时间（预计完工时间）
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 工单状态 1未生产 2 暂停 3 已完工 4 已取消 5 指定完工
        /// </summary>
        public string MO_State { get; set; }
        /// <summary>
        /// 工单日期
        /// </summary>
        public DateTime Shift_Date { get; set; }
        /// <summary>
        /// 班次号（目前自定义为01早班  02晚班）
        /// </summary>
        public string Shift_No { get; set; }
        /// <summary>
        /// 班计划数量
        /// </summary>
        public decimal Shift_Num { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 是否已处理 1:已处理 0:待处理
        /// </summary>
        public int IsProcessed { get; set; }
        /// <summary>
        /// 处理结果
        /// </summary>
        public string ProcessResult { get; set; }
        /// <summary>
        /// 订单执行优先等级   新增：订单紧急程度说明
        /// </summary>
        public string Add_Info { get; set; }
        /// <summary>
        /// 新数据标记，下发时设为true
        /// </summary>
        public string Flag { get; set; }


    }

}
