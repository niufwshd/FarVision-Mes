using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Equipment
{
   public class EquipmentResult
    {
        public string date { get; set; }
        public string data { get; set; }
    }

    public class EquipmentModel
    {
        public string pdline { get; set; }
        public DateTime startime { get; set; }
        public DateTime endtime { get; set; }
        public string name { get; set; }
        public string status { get; set; }
    }
    
    
}
