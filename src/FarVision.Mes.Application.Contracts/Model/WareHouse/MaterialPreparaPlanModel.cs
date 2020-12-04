using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 备料计划实体
    /// </summary>
    public class MaterialPreparaPlanModel
    {

        public string ID { get; set; }
        /// <summary>
        /// 备料计划单号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_No { get; set; }
        /// <summary>
        /// 单据类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string Dept { get; set; }
        public string DeptName { get; set; }
        /// <summary>
        /// 来源编号
        /// </summary>
        public string SourceNo_Form { get; set; }

        public string SourceName_Form { get; set; }
        /// <summary>
        /// 目标编号
        /// </summary>
        public string TargetNo_Form { get; set; }

        public string TargetName_Form { get; set; }
        /// <summary>
        /// 开工日期(来源工单的预开工日期)
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 工作中心
        /// </summary>
        public string WkCenter_No { get; set; }

        /// <summary>
        /// 优先级顺序 （来源工单的生产顺序）
        /// </summary>
        public string PriorityOrder { get; set; }
        /// <summary>
        /// 交货日期
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// 预计完工时间
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 录单人编号
        /// </summary>
        public string USR { get; set; }

        /// <summary>
        /// 录单人名称
        /// </summary>
        public string USRNAME { get; set; }

        /// <summary>
        /// 物料拉动ID
        /// </summary>
        public string MaterialRequestID { get; set; }
        /// <summary>
        /// 单据子表 （产品明细）
        /// </summary>
        public List<MaterialPreparaPlanItemModel> ProductList { get; set; }


    }
    /// <summary>
    /// 备料计划行项目
    /// </summary>
    public class MaterialPreparaPlanItemModel
    {
        //捡料单号
        public string PickMaterialNo { get; set; }

        public string ID { get; set; }


        public string MID { get; set; }


        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string Prod_Name { get; set; }

        /// <summary>
        /// 产品规格
        /// </summary>
        public string Prod_SPC { get; set; }

        /// <summary>
        /// 产品简称
        /// </summary>
        public string Prod_SNM { get; set; }


        /// <summary>
        /// 母件产品编号
        /// </summary>
        public string MProd_No { get; set; }

       /// <summary>
       /// 母件产品名称
       /// </summary>
        public string MProd_Name { get; set; }

        /// <summary>
        /// 母件产品规格
        /// </summary>

        public string MProd_SPC { get; set; }

        /// <summary>
        /// 需求数量
        /// </summary>
        public decimal PlanQuantity { get; set; }


        /// <summary>
        /// 损耗数量
        /// </summary>
        public decimal LossQuantity { get; set; }

        /// <summary>
        /// 确认数量
        /// </summary>
        public decimal ConfirmQuantity { get; set; }

        /// <summary>
        /// 转单数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 移库数量
        /// </summary>
        public decimal TransferQuantity { get; set; }

        /// <summary>
        /// 未完成数量
        /// </summary>
        public decimal UnFinishedQuantity { get; set; }

        /// <summary>
        /// 完成数量
        /// </summary>
        public decimal FinishQuantity { get; set; }

        /// <summary>
        /// 拣料数量
        /// </summary>
        public decimal PickMaterialQuantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }


        /// <summary>
        /// 类型 （人工，计划，安灯）
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }


        public string LineNumber { get; set; }

        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        /// 工作中心编号
        /// </summary>
        public string WkCenter_No { get; set; }

        /// <summary>
        /// 工作中心名称
        /// </summary>
        public string WkCenter_Name { get; set; }

        /// <summary>
        /// 来源仓库
        /// </summary>
        public string SourceWareHouse { get; set; }

        /// <summary>
        /// 来源仓库名称
        /// </summary>
        public string SourceWareHouseName { get; set; }
        /// <summary>
        /// 目标仓库
        /// </summary>
        public string TargetWareHouse { get; set; }
        /// <summary>
        /// 目标仓库名称
        /// </summary>

        public string TargetWareHouseName { get; set;}

        /// <summary>
        /// 上线时间(工单的预开工日期)
        /// </summary>
        public string StartDate { get; set; }


        /// <summary>
        /// 最晚送达时间
        /// </summary>
        public string DeadLineDate { get; set; }

        /// <summary>
        /// 生产顺序
        /// </summary>
        public string WorkOrder { get; set; }

        /// <summary>
        /// 加急说明
        /// </summary>
        public string Add_Info { get; set; }


        /// <summary>
        /// 最小包装数
        /// </summary>
        public decimal SmallestPackage { get; set; }

        /// <summary>
        /// 仓库管理员
        /// </summary>
        public string WHAdmin { get; set; }

        /// <summary>
        /// 物料BOM标准用量
        /// </summary>
        public decimal StandardQty { get; set; }

        /// <summary>
        /// 是否齐套拣料
        /// </summary>
        public bool IsGroupPickMaterial { get; set; }
                     
        /// <summary>
        /// 产品条码（包装）
        /// </summary>
        public  List<ProductBarcodeModel> ProductBarcodeList { get; set; }
    }


   

}
