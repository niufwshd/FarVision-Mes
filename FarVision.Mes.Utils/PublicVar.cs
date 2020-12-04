using YueMES.Base.Dal;
using YueMES.Data.Utils;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using WebMES.Utils.Cache;

namespace WebMES.Utils
{

    public static class PublicVar
    {
        public static string MesSysDBName = "WebMESSystem";

        public static ConcurrentDictionary<string, SessionInfo> SessionInfos = new ConcurrentDictionary<string, SessionInfo>();
        // public static OAuthBearerAuthenticationOptions OAuthOptions { get;  set; }
        public static SymmetricSecurityKey SymmetricKey { get;set;}
        public static SessionInfo GetSessionByToken(string token)
        {
            if (string.IsNullOrEmpty(token)) return null;
            return AppCache.GetCache<SessionInfo>(token);

        }
        
        public static void AddSession(string token, SessionInfo info)
        {
            AppCache.Add(token, info, 3);
            
        }
        public static void RemoveReportData(SessionInfo info,string busiNo)
        {
            if (info == null) return;
            if(info.ReportDatas.ContainsKey(busiNo))
                info.ReportDatas.Remove(busiNo);
        }


    }

    public class SessionInfo
    {

        public SessionInfo(DateTimeOffset? ExpiresUtc, string UserNo, string dBNo, string LangNo)
        {
            this.UserNo = UserNo;
            this.DBNo = dBNo;
            this.LangNo = LangNo;
            this.ExpiresUtc = ExpiresUtc;
            ReportDatas = new Dictionary<string, BDOs>();
        }
        public int UserID;
        public readonly string UserNo;
        public readonly string DBNo;
        public readonly string LangNo;
        public int Expiration = -1;

        //Gets or sets the issuance date and time of authentication.
       // public DateTimeOffset? IssuedUtc { get; set; }
        // Gets or sets the expiration date and time of authentication.
        public DateTimeOffset? ExpiresUtc { get; set; }
        public Dictionary<string, BDOs> ReportDatas;
    
    }



  
   




    
}
