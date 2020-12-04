using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Data
{
    public class ProduceDetailedReq
    {

        public string DEP { get; set; }

        public string ZC_NO { get; set; }

        public string PDLine { get; set; }

        public int DateType { get; set; }

        public string beginDate { get; set; }

        public string endDate { get; set; }

        public int pageIndex { get; set; }

        public int pageSize{ get; set; }

        public int selectAll { get; set; }
    }
}
