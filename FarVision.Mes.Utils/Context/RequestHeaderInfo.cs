using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebMES.Utils.Context
{
    public class RequestHeaderInfo
    {
       
        public string LangNo = "02";
        public string DBNo = "";
        public string MenuNo = "";
        public string WorkSys = "ALL";
        public string UserNo = "";
        public string UserName = "";
        public string IpAddress = "";

        int threadID = -1;
        public int ThreadID {
            get { return threadID; }
        }
        public RequestHeaderInfo()
        { threadID = Thread.CurrentThread.ManagedThreadId; }
        public RequestHeaderInfo(object langNo,string dbno)
        {
            LangNo = string.Format("000{0}", langNo);
            LangNo = LangNo.Substring(LangNo.Length - 2);
            DBNo = dbno;
            threadID = Thread.CurrentThread.ManagedThreadId;
        }
        public RequestHeaderInfo(string langNo, string dbno, string menuNo, string userNo, string userName, string ipAdd, string workSys="ALL")
        {
            LangNo = string.Format("000{0}", langNo);
            LangNo = LangNo.Substring(LangNo.Length - 2);
            DBNo = dbno;
            MenuNo = menuNo;
            UserNo = userNo;
            UserName = userName;
            IpAddress = ipAdd;
            WorkSys = workSys;
            threadID = Thread.CurrentThread.ManagedThreadId;
        }
    }
}
