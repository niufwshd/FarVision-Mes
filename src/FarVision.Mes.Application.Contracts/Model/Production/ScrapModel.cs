using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Production
{
    //报废，报可疑参数
    public class ScrapModel
    { 
      /// <summary>
      /// 工单
      /// </summary>
      public string TZ_NO { get; set; }
    
      /// <summary>
      ///品号
      /// </summary>
      public string PRD_NO { get; set; }

        /// <summary>
        ///工序
        /// </summary>
        public string ZC_NO { get; set; }
        /// <summary>
        ///设备
        /// </summary>
        public string SEB_NO { get; set; }

        /// <summary>
        /// 班次
        /// </summary>
        public string BAN_NO { get; set; }

        /// <summary>
        /// 任务单
        /// </summary>
        public string MO_NO { get; set; }
        /// <summary>
        /// 产品二维码
        /// </summary>
        public string PRD_QR { get; set; }
        /// <summary>
        /// 产品过点记录ID
        /// </summary>
        public string PRD_QR_ID { get; set; }
        /// <summary>
        /// 是否单件
        /// </summary>
        public string ISPIECE_MNG { get; set; }

        
        public string USR { get; set; }

        public string USERNAME { get; set; }
    }
}
