using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.SCMModels.Model.ResponseModels
{
    public class WorkOrderResponseModel
    {
      
            public string Authorization { get; set; }
            public List<WorkOrderResponseItem> Data { get; set; }
     }

     public class WorkOrderResponseItem
    {
         public string outbh {get;set;}
		 public string out01 {get;set;}
		 public string out02 {get;set;}
		 public int out03 {get;set;}
         public string out04 {get;set;}
		 public string out05 {get;set;}
		 public string out06 {get;set;}
         public string out07 {get;set;}
		 public int out08 {get;set;}
		 public string out09 {get;set;}
		 public string  out10 {get;set;}
		 public string out11 {get;set;} 
		 public string out12 {get;set;}
		 public string out13 {get;set;} 
		 public string out14 {get;set;}
		 public string out15 {get;set;}
		 public int out16 {get;set;}
		 public string out17 {get;set;}
		 public string out18 {get;set;}
		 public string out21 {get;set;}
		 public string  out22 {get;set;}

        /// <summary>
        /// 物料来源编号
        /// </summary>
        public string out23 { get; set; }

        /// <summary>
        /// 物料来源名称
        /// </summary>
        public string out24 { get; set; }


		 public string out31 {get;set;}
		 public string out33 {get;set;}
		 public string out34 {get;set;}
         public string out38 {get;set;}

         public string out40 { get; set;}

         public int out41 {get;set;}

        /// <summary>
        /// 投入品号
        /// </summary>
        public string out44 { get; set; }

        /// <summary>
        /// 投入品名
        /// </summary>
        public string out45 { get; set; }
        /// <summary>
        /// 投入品号规格
        /// </summary>
        public string out46 { get; set; }
        /// <summary>
        /// 投入品号单位
        /// </summary>
        public string out47 { get; set; }

         public string FLAG {get;set;}

        /// <summary>
        /// 来源物料工单
        /// </summary>
        public string out48 { get; set; }
      }
}
