using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Production
{

    public class PDRollBackModel
    {
       
        public string rollBackZC_NO { get; set; }
     
        public string rollToZC_NO { get; set; }
 
        public string wrNo { get; set; }

        public string moNo { get; set; }
        public string idNo { get; set; }
  
        public string sal_no { get; set; }

        public string prdNo { get; set; }
 
        public string backReason { get; set; }

        public string unit { get; set; }
        public string tz_no { get; set; }

        public decimal qty { get; set; }
    
        public decimal qty_lost { get; set; }

        public decimal qty_scrap { get; set; }

        public List<string> barList { get; set; }
    }
}
