using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class dncYieldDTO
    {
        [DataMember]
        public string ip { get; set; }
        [DataMember]
        public string macNo { get; set; }
        [DataMember]
        public decimal qty { get; set; }
        [DataMember]
        public DateTime timeStamp { get; set; }

    }
    [DataContract]
    public class dncParas
    {

        // [DataMember]
        //public string macNo { get; set; }

        // [DataMember]
        //public string paras { get; set; }
        [DataMember]
        public string MacNo { get; set; }
        [DataMember]
        public DateTime TimeStamp { get; set; }
        [DataMember]
        public string AlarmCode { get; set; }
        [DataMember]
        public decimal Qty { get; set; }
        [DataMember]
        public string Status { get; set; }

        ///// <summary>
        ///// 数据流水号
        ///// </summary>
        //[DataMember]
        //public string IDnum { get; set; }
        /////<summary>
        /////设备编号
        /////</summary>
        //[DataMember]
        //public string MachineName { get; set; }
        /////<summary>
        /////机床模式
        /////</summary>
        //[DataMember]
        //public string MachineMode { get; set; }
        /////<summary>
        /////状态
        /////</summary>
        //[DataMember]
        //public string MachineStatus { get; set; }
        /////<summary>
        /////开机时间(累计值)
        /////</summary>
        //[DataMember]
        //public string PowerOnTime { get; set; }
        /////<summary>
        /////运行时间(累计值)
        /////</summary>
        //[DataMember]
        //public string RunningTime { get; set; }
        /////<summary>
        /////切削时间(累计值)
        /////</summary>
        //[DataMember]
        //public string CuttingTime { get; set; }
        /////<summary>
        /////总产量
        /////</summary>
        //[DataMember]
        //public string ProcessedCount { get; set; }
        /////<summary>
        /////主轴负载
        /////</summary>
        //[DataMember]
        //public string SpindleLoad { get; set; }
        /////<summary>
        /////转速
        /////</summary>
        //[DataMember]
        //public string SpindleSpeed { get; set; }
        /////<summary>
        /////进给
        /////</summary>
        //[DataMember]
        //public string FeedSpeed { get; set; }
        /////<summary>
        /////主轴倍率
        /////</summary>
        //[DataMember]
        //public string SpindleOverride { get; set; }
        /////<summary>
        /////进给倍率
        /////</summary>
        //[DataMember]
        //public string FeedOverride { get; set; }
        /////<summary>
        /////报警号
        /////</summary>
        //[DataMember]
        //public string AlarmNo { get; set; }
        /////<summary>
        /////报警信息
        /////</summary>
        //[DataMember]
        //public string AlarmMessage { get; set; }
        /////<summary>
        /////当前刀具号
        /////</summary>
        //[DataMember]
        //public string Toolnum { get; set; }
        /////<summary>
        /////坐标值X
        /////</summary>
        //[DataMember]
        //public string Xload { get; set; }
        /////<summary>
        /////坐标值Y
        /////</summary>
        //[DataMember]
        //public string Yload { get; set; }
        /////<summary>
        /////坐标值Z
        /////</summary>
        //[DataMember]
        //public string Zload { get; set; }
        /////<summary>
        /////创建时间
        /////</summary>
        //[DataMember]
        //public DateTime CreateTime { get; set; }

    }

     [DataContract]
     public class dncAlert
     {
         [DataMember]
         public string macNo { get; set; }

         [DataMember]
         public string alarmCode { get; set; }

         [DataMember]
         public DateTime timeStamp { get; set; }
     }
}
