using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Equipment
{
    //报工品名参数
    public class PRDTFilter
    {
        public DateTime startime { get; set; }
        public DateTime endtime { get; set; }
        public string zc_no{get; set; }
        public string seb_no { get; set; }

        public DateTime NowDate { get; set; }
        public string NowBanNo { get; set; }
        public DateTime LastDate { get; set; }
        public string LastBanNo { get; set; }
    }
}


