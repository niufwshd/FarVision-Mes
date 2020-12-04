using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// SCM请求接口
    /// </summary>
    public class SCMRequestModel<T>
    {
        /// <summary>
        /// 请求头
        /// </summary>
        public string Authorization { get; set; }
        /// <summary>
        /// 实体
        /// </summary>
        public T Data { get; set; }
    }



}
