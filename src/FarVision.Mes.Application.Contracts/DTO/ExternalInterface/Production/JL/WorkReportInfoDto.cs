using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.ExternalInterface.Production.JL
{
    /// <summary>
    ///  产品过点报工 数采系统->MES 
    /// </summary>
    [Serializable]
    public class WorkReportInfoDto
    {

        /// <summary>
        /// 记录惟一标识号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string Dev_No { get; set; }

        /// <summary>
        /// 模具号
        /// </summary>
        public string MouldNo { get; set; }

        /// <summary>
        /// 图号
        /// </summary>
        public string FigureNo { get; set; }
        /// <summary>
        /// 历史图号
        /// </summary>
        public string DrawNo_His { get; set; }
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_No { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string PRD_No { get; set; }
        /// <summary>
        /// 合格件数量
        /// </summary>
        public decimal Qty { get; set; }
        /// <summary>
        /// 不合格件数量
        /// </summary>
        public decimal Qty_LOST { get; set; }
        /// <summary>
        /// 报废数量 
        /// </summary>
        public decimal ScrapQty { get; set; }
        /// <summary>
        /// 不合格原因 
        /// </summary>
        public string SPC_No { get; set; }
        /// <summary>
        /// 报废原因
        /// </summary>
        public string ScrapCode { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 是否需要处理 1:已处理 0:待处理
        /// </summary>
        public bool IsProcessed { get; set; }
        /// <summary>
        /// 处理结果
        /// </summary>
        public string ProcessResult { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        public string Process_No { get; set; }



    }
}
