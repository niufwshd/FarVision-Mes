using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebMES.Model.SCMModels.Model.ResponseModels
{
    public class MES2SCMResult
    {
         public int Code { get; set; }
         public string Msg { get; set; }
         public List<Object> Data { get; set; }
    }
}