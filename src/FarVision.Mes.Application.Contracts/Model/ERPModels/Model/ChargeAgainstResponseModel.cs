using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class ChargeAgainstResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_DJCS";

        public List<ChargeAgainstResponseHead> Data { get; set; }
    }

    public class ChargeAgainstResponseHead
    {
         	public string SP001 { get; set;}
			public string SP002 { get; set; }
    }
}
