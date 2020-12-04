using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    /// <summary>
    /// 委外进货erp接口实体
    /// </summary>
    public class OutsideStockGoodsResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_MOCI06";

        public List<OutsideStockGoodsResponseHead> Data { get; set; }
    }

    public class OutsideStockGoodsResponseHead
    {
        public string TH001 { get; set; }

        public string TH002 { get; set; }
        public string TH004 { get; set; }
        public string TH005 { get; set; }
        public string TH029 { get; set; }

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


        public string TI004 { get; set; }
        public string TI009 { get; set; }
        public string UDF04 { get; set; }
        public string TI013 { get; set; }
        public string TI014 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TI015 { get; set; }
        /// <summary>
        /// 送货数量
        /// </summary>
        public decimal TI007 { get; set; }  
        /// <summary>
        /// 验收数量
        /// </summary>
        public decimal TI019 { get; set; }
        /// <summary>
        /// 验退数量
        /// </summary>
        public decimal TI022 { get; set; }

        public string TI008 { get; set; }
        public string TI043 { get; set; }


        /// <summary>
        /// 让步接收
        /// </summary>
        public decimal UDF62 { get; set; }

        /// <summary>
        /// 限制使用
        /// </summary>
        public decimal UDF61 { get; set; }

        /// <summary>
        /// 报废数量
        /// </summary>
        public decimal TI021 { get; set; }

        /// <summary>
        /// 厂内检验报废数量
        /// </summary>
        public decimal UDF60 { get; set; }

        /// <summary>
        /// 供应商检验报废数量
        /// </summary>
        public decimal UDF59 { get; set;}

        /// <summary>
        /// 待处置数量
        /// </summary>
        public decimal UDF58 { get; set; }

        /// <summary>
        /// 破坏数量   = 厂内检验报废数量 + 供应商检验报废数量
        /// </summary>
        public decimal TI056 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TI003 { get; set; }



      

    }
}
