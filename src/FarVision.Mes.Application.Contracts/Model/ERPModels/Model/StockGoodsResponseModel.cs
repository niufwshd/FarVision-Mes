using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class StockGoodsResponseModel
    {
        public string STD_IN_Origin { get; set; }
        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_PURI09";

        public List<StockGoodsResponseHead> Data { get; set; }
    }



    public class StockGoodsResponseHead
    {
        /// <summary>
        /// ERP单别
        /// </summary>
        public string TG001 { get; set; }
        /// <summary>
        /// ERP单号
        /// </summary>
        public string TG002 { get; set; }
        /// <summary>
        /// 工厂代码
        /// </summary>
        public string TG004 { get; set; }
        /// <summary>
        /// 记账日期
        /// </summary>
        public string TG014 { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        public string TG003 { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public string TG005 { get; set; }
        public string TH011 { get; set; }
        public string TH012 { get; set; }
        public string TH013 { get; set; }
        public string UDF03 { get; set; }
        public string UDF04 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TH004 { get; set; }
        /// <summary>
        ///  送货数量
        /// </summary>
        public decimal TH007 { get; set; }
        /// <summary>
        /// 验收数量
        /// </summary>
        public decimal TH015 { get; set; }
        /// <summary>
        /// 验退数量
        /// </summary>
        public decimal TH017 { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string TH008 { get; set; }
        /// <summary>
        /// 入库仓库
        /// </summary>

        public string TH009 { get; set; }
        /// <summary>
        /// 厂内检验报废数量
        /// </summary>
        public decimal UDF51 { get; set; }

        /// <summary>
        /// 供应商检验报废数量
        /// </summary>
        public decimal UDF52 { get; set; }
        /// <summary>
        /// 待处置数量
        /// </summary>
        public decimal UDF53 { get; set; }




        /// <summary>
        /// 破坏数量
        /// </summary>
        public decimal TH068 { get; set; }




        /// <summary>
        /// 让步接收数量
        /// </summary>
        public decimal UDF61 { get; set;}

        /// <summary>
        /// 报废数量
        /// </summary>
        public decimal TH061 { get; set; }

        /// <summary>
        /// 限制使用
        /// </summary>
        public decimal UDF60 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TH003 { get; set; }


    }

}
