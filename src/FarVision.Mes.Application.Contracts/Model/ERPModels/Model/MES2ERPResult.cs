using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebMES.Model.ERPModels.Model.ResponseModels
{
    public class MES2ERPResult
    {

        public string STD_OUT_Origin { get; set; }

        public ErpResultService Service { get; set; }
    }

    public class ErpResultService
    {
        public string Status { get; set; }
        public ResultMsg Data { get; set; }
    }

    public class ResultMsg
    {
        public string Message { get; set; }
    }
}