using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// ERP请求接口
    /// </summary>
    public class ERPRequestModel<T>
    {
        //请求头
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_MOCI04";
        /// <summary>
        /// 实体
        /// </summary>
        public T Data { get; set; }
    }



}
