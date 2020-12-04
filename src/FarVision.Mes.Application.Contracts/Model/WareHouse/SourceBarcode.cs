using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 条码主表
    /// </summary>
    public class SourceBarcodeEntity
    {
        /// <summary>
        /// 来源单类别
        /// </summary>
        public string Src_Type { get; set; }
        /// <summary>
        /// 来源单号
        /// </summary>
        public string Src_No { get; set; }
        /// <summary>
        /// 来源条码
        /// </summary>
        public string Src_Barcode { get; set; }
        /// <summary>
        /// 项次
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// 厂商编号
        /// </summary>
        public decimal Vendor_No { get; set; }
        /// <summary>
        /// 品号
        /// </summary>
        public string Prod_No { get; set; }
        /// <summary>
        /// 品名
        /// </summary>
        public string Prod_Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Prod_Spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty { get; set; }

        /// <summary>
        /// 包装换算(每箱数量)
        /// </summary>
        public decimal Pkg_Conver { get; set;}

        /// <summary>
        /// 包装数量(箱数)
        /// </summary>
        public decimal Qty_Pkg { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public string Dept { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 条码类型  1.批次,2.包装,3.资源
        /// </summary>
        public string BarcodeType { get; set; }

        public string Mold_No { get; set; }


        public string Src_ItemID { get; set; }

        public string Rem { get; set; }


        /// <summary>
        /// 工序
        /// </summary>
        public string ProcessNo { get; set; }



       /// <summary>
       /// 任务单
       /// </summary>
        public string MO_NO { get; set; }

        /// <summary>
        /// 工位
        /// </summary>
        public string Station_No { get; set; }

        /// <summary>
        /// 条码集合
        /// </summary>
        public List<BarcodeEntity> barcodeList { get; set; }


    }

    public class BarcodeEntity
    {
        /// <summary>
        /// 条码
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        ///  类型  1.批次,2.包装,3.资源
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

    }
}
