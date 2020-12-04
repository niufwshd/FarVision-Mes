using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.DTO.Production;

namespace WebMES.Model.Production
{


    [Serializable]
    public class BarCodeModel
    {

        public string barcode_Pkg { get; set; }
        public string barCode { get; set; }

        public string prodNo { get; set; }

        public string prodSpec { get; set; }

        public string whse_No { get; set; }

        public string wo_no { get; set; }

        public string process_no { get; set; }

        public string stationNo { get; set; }

        public string dev_no { get; set; }

        public string sal_no { get; set; }

        public string code_Status { get; set; }

        public string entryID { get; set; }

        public string spcNo { get; set; }

        public string spcName { get; set; }

        public string mo_no { get; set; }
        public string id_no { get; set; }

        public string SPC_DESCR { get; set; }

        public string RESP_ZCNO { get; set; }

        public DateTime DSP_DD { get; set; }


        public DateTime scanTime { get; set; }

        public string BAN_NO { get; set; }

        public string DEPT { get; set; }

        public string STEEL_NO { get; set; }

        /// <summary>
        /// 自制件类型
        /// </summary>
        public string selfMadeType { get; set; } 
        /// <summary>
        /// //0-unchange,1-add,2-modify,3-delete,4-unDef
        /// </summary>

        public int dataState { get; set; }


        public bool IsBatTray { get; set; }

        public decimal Qty { get; set; }
        public decimal QtyUnOk { get; set; }
        public decimal QtyScrap { get; set; }
        public decimal QtyRepair { get; set; }
        public int QtyPkg { get; set; }

        public BarCodeModel()
        {
            defectList = new List<DefectList>();
            bindingList = new List<bindingInfo>();
            IsBatTray = false;
            QtyPkg = 0;
            barQty = 0;
        }
        /// <summary>
        /// 报工单号
        /// </summary>
        public string WR_NO { get; set; }

        public string batchNo { get; set; }

        public string unit { get; set; }

        public bool integrityCheck { get; set; }

        public int barQty { get; set; }

        public List<DefectList> defectList { get; set; }

        public List<bindingInfo> bindingList { get; set; }

    }
    
   
    [Serializable]
    public class bindingInfo
    {
        public string barcode { get; set; }
        public string prdNo { get; set; }
        public string prdName { get; set; }
        public int qty { get; set; }

    }

}
