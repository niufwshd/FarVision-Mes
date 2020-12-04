using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Common
{
    [DataContract]
    public class WHInfo
    {
        /// <summary>
        /// 储位
        /// </summary>
         [DataMember]
        public string StorageNo;

        /// <summary>
        /// 是储位
        /// </summary>
         [DataMember]
         public bool IsStorageNo;

        /// <summary>
        /// 所属仓库
        /// </summary>
         [DataMember]
        public string WHNO;
         [DataMember]
        public string WHNAME;
    }
}
