using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class DiscardResponseModel
    {
        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_INVI23";

        public List<DiscardResponseHead> Data { get; set; }
    }


    //报废单
    public class DiscardResponseHead
    {
        public string TL001 { get; set; }
        public string TL002 { get; set; }
        public string TL007 { get; set; }
        public string TL004 { get; set; }
        public string TL003 { get; set; }
        public string TL015 { get; set; }
        public string TL013 { get; set; }
        public string TL008 { get; set; }
        public string TM004 { get; set; }
        public string TM014 { get; set; }
        public string TM015 { get; set; }
        public decimal TM007 { get; set; }
        public string TM008 { get; set; }

        /// <summary>
        /// 来源单别
        /// </summary>
        public string TM009 { get; set;}
        /// <summary>
        /// 来源单号
        /// </summary>
        public string TM010 { get; set; }
        /// <summary>
        /// 来源序号
        /// </summary>
        public string TM011 { get; set; }

        //序号
        public string TM003 { get; set; }



    }
}
