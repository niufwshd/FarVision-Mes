using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Data
{
    public class RequestHeaderInfo
    {
        public string LangNo = "02";
        public string DBNo = "";
        public string MenuNo = "";
        public string UserNo = "";
        public RequestHeaderInfo()
        { }
        public RequestHeaderInfo(object langNo)
        {
            LangNo = string.Format("000{0}", langNo);
            LangNo = LangNo.Substring(LangNo.Length - 2);
        
        }
        public RequestHeaderInfo(string langNo,string dbno,string menuNo,string userNo)
        {
            LangNo = string.Format("000{0}", langNo);
            LangNo = LangNo.Substring(LangNo.Length - 2);
            DBNo = dbno;
            MenuNo = menuNo;
            UserNo = userNo;

        }
    }
}
