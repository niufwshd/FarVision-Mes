using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Mold
{
    /// <summary>
    /// 模具库房状态
    /// </summary>
    public class MoldWhseModel
    {
        public string MoldNo { get; set; }


        /// <summary>
        /// 模具序列号
        /// </summary>
        public string MoldSn { get; set; }


        /// <summary>
        /// 来源单号
        /// </summary>
        public string Src_No { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        public string Src_ItemID { get; set; }

        /// <summary>
        /// 1:在库,2:领出,3:使用,4:停用,5:报废,6:待保养,7:保养,8:待修,9:维修中,10:维修完成,11:待检,12:检验,13:检验合格,14:检验不合格
        /// </summary>
        public int Status { get; set; }
    }

    
}
