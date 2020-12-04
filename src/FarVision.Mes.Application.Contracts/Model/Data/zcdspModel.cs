using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Data
{
    /// <summary>
    /// 不合格处理数据模型
    /// </summary>
    public class ZCDSPModel
    {
        string _spcStr = "";
        /// <summary>
        /// 不合格原因类别
        /// </summary>
        public string Spc_type { get; set; }

        public List<SpcInfos> spcList { get; set; }

        public string spcStr {

            get 
            {
                if(!string.IsNullOrEmpty(_spcStr)) return _spcStr;
                spcList.OrderBy(o => o.Spc_no);
                StringBuilder sbd = new StringBuilder();
                foreach (var itm in spcList)
                {
                    sbd.Append(itm.Spc_no);
                }
                _spcStr = sbd.ToString();
                return _spcStr;
            }
        }
        public ZCDSPModel() 
        {
            spcList = new List<SpcInfos>();
        }
    }

    public class SpcInfos
    {
        public string Spc_no { get; set; }
        public string Spc_name { get; set; }

        public string RESP_ZCNO { get; set; }
        public long Qty { get; set; }


    }
}
