using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Equipment
{
    //设备产线停机时长分析报表 过滤参数
    public class EquipmentFilter
    {
        public DateTime startime { get; set; }
        public DateTime endtime { get; set; }
        public string line{get; set; }
        public string sebeiname { get; set; }
        public string busino { get; set; }
    }
    public class Line
    {
        public string pdline { get; set; }
    }
    public class Sebeiname
    {
        public string name { get; set; }
    }
}


