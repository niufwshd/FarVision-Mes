using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 齐套叫料实体
    /// </summary>
    public class MaterialKittingModel
    {
      
        public string WO_NO { get; set; }


        public string PROD_NO { get; set; }


        public string Ver_NO { get; set; }

        public decimal Quantity { get; set; }

        /// <summary>
        /// 原料仓库
        /// </summary>
        public string MaterialWareHouse { get; set; }

        // 工位
        public string Station_No { get; set; }

        //工作中心
        public string WK_Center_NO { get; set; }

        //工序
        public string Process_No { get; set; }

        //预开工日
        public string StartDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
    }
}
