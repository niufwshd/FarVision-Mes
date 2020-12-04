using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.SysData
{
    [DataContract]
    [ProtoContract]
    public class Sys_UserDTO:BaseDTO
    {
        [ProtoMember(1)]
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        [ProtoMember(2)]
        [DataMember]
        public string No { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [ProtoMember(3)]
        [DataMember]
        public string Name { get; set; }
        ///// <summary>
        ///// 密码
        ///// </summary>
        //[DataMember]
        //public string Pwd { get; set; }
        private int UserType { get; set; }
      //    [DataMember]
        public bool IsLock { get; set; }
       //   [DataMember]
        public bool IsAdmin { get; set; }
        [DataMember]
        public string DEP { get; set; }

        [DataMember]
        public string DepName { get; set; }

        [DataMember]
        public string SAL_NO { get; set; }

        [DataMember]
        public string SAL_NAME { get; set; }

        [DataMember]
        public string SEX { get; set; }
        //班组
        [DataMember]
        public string WorkGroup { get; set; }

    }
}
