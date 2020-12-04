using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Trace
{    
    //追溯参数
    public class MouldingFilter
    {
        public DateTime startDD { get; set; }
        public DateTime endDD { get; set; }
        public string batNoStart { get; set; }
        public string batNoEnd { get; set; }
        public string prdNoStart { get; set; }
        public string prdNoEnd { get; set; }
        //造型参数
        public string Mouldpara { get; set; }

        //数采参数
        public DateTime pourStardd { get; set; }
        public DateTime pourEnddd { get; set; }
        public string pourSBBH { get; set; }
        public string pourCSBH { get; set; }

        //浇注，混沙参数：炉批号
        public string SO_BAT_NO { get; set;}

    }
    public class SO_BAT_NO
    {
        public string name { get; set; }
    }

    public class Mouldpara
    {
        public string name { get; set; }
    }

}
