using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 委外收货接口实体
    /// </summary>
    public class ReceivedMaterialOutSource
    {
        /// <summary>
        ///  送货单号
        /// </summary>
        public string tra_no { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        public string trab20 { get; set; }

        /// <summary>
        /// 到货数量
        /// </summary>
        public decimal trab07 { get; set; }

        /// <summary>
        /// 拒收数量
        /// </summary>
         public decimal trab08 { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string trab30 { get; set; }
    }
}
