using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.Reports
{
     [DataContract]
    public class engChartDataDto
    {
         [DataMember]
         public string name { get; set; }

         [DataMember]
         public List<string> category { get; set; }

         [DataMember]
         public List<engSerieData> ListSeriesDatas { get; set; }

         public engChartDataDto()
         {
             category = new List<string>();
             ListSeriesDatas = new List<engSerieData>();
         }

    }

     [DataContract]
     public class engSerieData
     {
         [DataMember]
         public string depNo { get; set; }
         [DataMember]
         public List<object> dataList { get; set; }
         [DataMember]
         public List<object> targetList { get; set; }

         public engSerieData()
         {
             dataList = new List<object>();
             targetList = new List<object>();

         }
     }
}
