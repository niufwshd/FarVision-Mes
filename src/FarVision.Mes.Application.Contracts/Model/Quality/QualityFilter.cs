using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Quality
{
    //质量参数模型
    public class QualityFilter
    {
       public DateTime StarDate { get; set; }
       public DateTime EndDate { get; set; }
       public string PRD_NO { get; set; }
       public string ZC_NO { get; set; }
       public string PRJ_TYPE { get; set; }
       public string QC_ITM { get; set; }
    }
}
