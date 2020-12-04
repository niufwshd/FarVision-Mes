using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Quality
{
    //质量参数模型
    public class QualityPrdt
    { /// <summary>
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
        /// 模具
        /// </summary>
        public string MO_NO { get; set; }
        /// <summary>
        /// 二维码
        /// </summary>
        public string QRCODE { get; set; }
        /// <summary>
        /// 是否单件
        /// </summary>
        public string ISPIECE_MNG { get; set; }

        public string usr { get; set; }

        public string USERNAME { get; set; }
    }
}
