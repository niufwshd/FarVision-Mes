using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Production
{
    public class RL_SBEI
    {
        public string BEGIN_DATE { get; set; }

        public string END_DATE { get; set; }

        public int ID { get; set; }

        public string SEB_NO { get; set; }

        public string BAN_NO { get; set; }

        public string ZC_NO { get; set; }

        public int STATE { get; set; }

        public List<int> ids { get; set; }

        public int page { get; set; }

        public int pageSize { get; set; }

        public int JL_ID { get; set; }


        public string TZ_NO { get; set; }

        public string OLD_CODE_STATUS { get; set; }

        public string CODE_STATUS { get; set; }

        public string User { get; set; }
    }
}
