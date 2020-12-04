using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace WebMES.Model.Quality
{
    /// <summary>
    /// 验收单实体
    /// </summary>
    public class AcceptanceFormModel
    {
        /// <summary>
        /// 验收单ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 验收单号
        /// </summary>
        public string BillNo { get; set; }

        /// <summary>
        /// 送检单号
        /// </summary>
        public string SourceBillNo { get; set; }

        /// <summary>
        /// 验收单状态
        /// </summary>
        public string BillStatus { get; set; }

        /// <summary>
        /// 客户/厂商
        /// </summary>
        public string SuppCode { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string DeptNo { get; set; }

        /// <summary>
        /// 检验员
        /// </summary>
        public string InspectorID { get; set; }

        /// <summary>
        /// 检验方式
        /// </summary>
        public string CHK_KND { get; set; }


        public List<AcceptanceSub> AcceptanceSubList { get; set; }

        public List<AcceptanceBarcode> QualifiedBarcodeList { get; set; }


    }


    public class AcceptanceSub
    {
        public string ID { get; set; }

        public string MID { get; set; }

        public string ProductionNo { get; set; }

        public string ProductionDate { get; set; }


        public string Unit { get;set; }
        public string qtyRBill { get; set; }

        public decimal QTY_CHK { get; set; }

        public decimal QTY_CHK_OK { get; set; }

        public decimal QTY_CHK_LOST { get; set; }

        public string BatchNo { get; set; }

        public string SPC_NO { get; set; }

        public string UnqulifiedType { get; set; }

        public decimal Qty { get; set; }

        public string PRC_ID { get; set; }

        public string InspectionDate { get; set; }

        public decimal QTY_OK_RTN { get; set; }


        public decimal QTY_LOST_RTN { get; set; }


        public string Comment { get; set; }


        public string SourceLocation { get; set; }

        /// <summary>
        /// 目的地  一般为待检区的库位 来源于 送检单的StorageLocation
        /// </summary>
        public string StorageLocation { get; set; }


        public string TargetWareHouse { get; set; }

        /// <summary>
        /// 生成的单据类型
        /// </summary>
        public string GenreateFormType { get; set; }





        public List<AcceptanceBarcode> AcceptanceBarcodeList { get; set; }

    }


    public class AcceptanceBarcode
    {
        public string ID { get; set; }

        public string MID { get; set; }

        public string Barcode { get; set; }

        public decimal Qty { get; set; }


        public string HandleResult { get; set; }

        public string HandleUser { get; set; }

        public string HandleDate { get; set; }


        public string Comment { get; set; }


        public string SourceLocation { get; set; }

        /// <summary>
        ///  批次
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set;}
    }
}
