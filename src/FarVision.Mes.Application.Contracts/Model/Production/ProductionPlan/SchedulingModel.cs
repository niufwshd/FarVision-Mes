using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.Production.ProductionPlan
{
    [Serializable]
   
    public  class SchedulingModel
    {
       
        public string workCenter { get; set; }
       
        public string moNo { get; set; }
        public string planNo { get; set; }

        public string prodNo { get; set; }

        public string prodName { get; set; }

        public string prodMark { get; set; }

        public string prodSpc { get; set; }

        public bool isVirtual { get; set; }
        public string srcNo { get; set; }


        public string unit { get; set; }

        /// <summary>
        /// 工艺流程版本号
        /// </summary>
        public string verNo { get; set; }
        /// <summary>
        /// 产品物料号
        /// </summary>
        public string bomNo { get; set; }

        public int sourceItemID { get; set; }

        public decimal qtySched { get; set; }

        public decimal qtyAll { get; set; }

        public decimal workOrder { get; set; } //生产顺序

        public string addInfo { get; set; } //订单(工单)说明

        public string woMode { get; set; }  //生产方式
        public string woType { get; set; }  //工单类型
        public string uniqueCode { get; set; } //唯一码

        public bool isUpdate { get; set; }   //是否更新

        public string woNoOri { get; set; }  //原始工单，用于更新时重新生成工单

       public string endWhse { get; set; }   //完工目的地 

        public SchedulingModel()
        {
            isUpdate = false;
            isVirtual = false;
            infos = new List<SchedulingInfo>();
            dispLevel = DispLevel.ProductionLine;
        }

        public DispLevel dispLevel { get; set; }
        
        public List<SchedulingInfo> infos { get; set; }

        [NonSerialized]
        public DataTable BomData;


    }
    [Serializable]
    public class SchedulingInfo
    {
        //public SchedulingInfo()
        //{
        //    detail = new List<SchedulingDetail>();
        //}
        public string layoutNo { get; set; }
        public string DeviceNo { get; set; }

        public string processNo { get; set; }

        public string shiftNo { get; set; }

        public DateTime planDate { get; set; }

        public DateTime? shiftDate { get; set; }

        public DateTime? EndDate { get; set; }
        public decimal planQty { get; set; }

        public string remark { get; set; }




        //public List<SchedulingDetail> detail { get; set; }
    }

    /// <summary>
    /// 派工层次
    /// </summary>
    public enum DispLevel
    {
        ProductionLine=0,
        WorkPosition=1
    }

    //public class SchedulingDetail
    //{
    //    public string shiftNo { get; set; }

    //    public DateTime planDate { get; set; }

    //    public DateTime shiftDate { get; set; }

    //    public decimal planQty { get; set; }

    //}
}
