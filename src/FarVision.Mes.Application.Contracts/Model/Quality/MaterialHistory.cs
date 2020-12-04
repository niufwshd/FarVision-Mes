using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Quality
{
    public class MaterialHistory
    {
        public string SEB_NO { get; set; }

        public string ZC_NO { get; set; }

        public string BAN_NO { get; set; }

        public string lastBanDate { get; set; }

        public string lastBanNo { get; set; }

        public int[]  IDList { get; set; }

        public string[] IDLists { get; set; }
    }
}
