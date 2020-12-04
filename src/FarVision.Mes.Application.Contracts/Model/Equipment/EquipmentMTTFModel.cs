using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Equipment
{
   public  class EquipmentMTTFModel
    {
        public string pdline { get; set; }
        public string sebname { get; set; }
        public decimal faultcount { get; set; }
        public decimal times { get; set; } 
    }
    public class EquipmentMTTFResult
    {
        public string name { get; set; }
        public decimal times { get; set; }
        public decimal faultCount { get; set; }
        public decimal Mttf { get; set; }
    }
}
