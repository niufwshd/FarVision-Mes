using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    /// <summary>
    /// 委外退货erp接口实体
    /// </summary>
    public class OutsideReturnGoodsResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_MOCI07";

        public List<OutsideReturnGoodsResponseHead> Data { get; set; }
    }

    public class OutsideReturnGoodsResponseHead
    {
        public string TK001 { get; set; }

        public string TK002 { get; set; }
        public string TK003 { get; set; }
        public string TK004 { get; set; }
        public string TK005 { get; set; }
        public string TK028 { get; set; }
        public string TL004 { get; set; }
        public string TL017 { get; set; }
        public decimal TL007 { get; set; }
        public string TL008 { get; set; }
        public string TL013 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string UDF04 { get; set; }
        public string TL015 { get; set; }
        public string TL016 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TL003 { get; set; }


        /// <summary>
        ///1	计价计量 代表MES抛给ERP的单据即影响加工费也影响库存
        ///2	计价不计量 代表MES抛给ERP的单据影响加工费但不影响库存
        ///3	不计价计量 代表MES抛给ERP的单据不影响加工费但影响库存
        ///4    不计价不计量 不抛erp
        /// </summary>
        public int UDF01 { get; set; }

        /// <summary>
        /// 用来标识是否需要发送erp工单 给erp
        /// </summary>
        public int UDF02 { get; set; }



    }
}
