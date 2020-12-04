using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 到货单验收数量
    /// </summary>
    public class ReceivedMaterial
    {
        /// <summary>
        ///  送货单号
        /// </summary>
        public string bih_no { get; set; }

        /// <summary>
        /// 标签二维码值
        /// </summary>
        public string bib01 { get; set; }

        /// <summary>
        /// asn行号
        /// </summary>
        public string bib19 { get; set; }

        /// <summary>
        /// 到货数量
        /// </summary>
        public decimal bib16 { get; set; }

        /// <summary>
        /// 拒收数量
        /// </summary>
         public decimal bib26 { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string bib23 { get; set; }
    }
}
