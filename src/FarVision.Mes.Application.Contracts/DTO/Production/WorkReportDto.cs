using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Production
{

    [Serializable]
    public class WorkReportDto:ICloneable
    {
        public WorkReportDto()
        {
            this.defectList = new List<DefectList>();
        }

        public string reportGuid { get; set; }
        public string woNo { get; set; }
        public string moNo { get; set; }

        public string processNo { get; set; }

        public string stationNo { get; set; }
        public string prodNo { get; set; }

        public string barcode { get; set; }

        public string usrExec { get; set; }

        public string usrNo { get; set; }

        public string usrName { get; set; }
        /// <summary>
        /// 库存类型
        /// </summary>
        public string storageType { get; set; }
        /// <summary>
        /// 是否装箱
        /// </summary>
        public bool isOnTray { get; set; }
        /// <summary>
        /// 标准装箱数
        /// </summary>
        public int pkgNum { get; set; }
        public int qty { get; set; }

        public int qtyNG { get; set; }

        public int qtyScrap { get; set; }
        public int qtyRepair { get; set; }

        public string unit { get; set; }

        public string verNo { get; set; }

        public string batchNo { get; set; }
        
        public string devNo { get; set; }


        /// <summary>
        /// 模具号，浇注用
        /// </summary>
        public string moldNo { get; set; }

        public string outBarcode { get; set; }

        public string shiftNo { get; set; }

        public string wkCenterNo { get; set; }

        /// <summary>
        /// 报工提供铸件批次,true时需输入批次,工序资料里设置
        /// </summary>
        public bool isNeedBatNoWhenReport { get; set; }

        /// <summary>
        /// 报工单ID
        /// </summary>
        public object rptID { get; set; }

        public string remark { get; set; }

        public List<DefectList> defectList { get; set; }
        public object Clone()
        {
            var copy = MemberwiseClone() as WorkReportDto;
            copy.defectList = new List<DefectList>(this.defectList);

            return copy;
        }
    }
}
