using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.SCMModels.Model.ResponseModels
{
 
        public class RecheckModelResponseModel
        {
            public string Authorization { get; set; }
            public List<RecheckModelResponseItem> Data { get; set; }
        }

        public class RecheckModelResponseItem
        {
            public string bih_no { get; set; }
            public int bib19 { get; set; }
            public int bib30 { get; set; }
            public int bib31 { get; set; }
            public int bib32 { get; set; }
            public int bib33 { get; set; }
            public int sgm08 { get; set; }
            public int sgm09 { get; set; }
            public string sgm15 { get; set; }
   
    }
}
