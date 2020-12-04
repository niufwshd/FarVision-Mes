using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model
{
    public class BaseModel
    {
        /// <summary>
        /// 接口ID
        /// </summary>
        public string ZINT_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ZTYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ZMESSAGE { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string ZZTIMESTAMP { get; set; }

        /// <summary>
        /// 每笔交易ID
        /// </summary>
        public string ZGUID { get; set; }

      
    }
}
