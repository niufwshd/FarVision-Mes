//using WebMES.Model.SystemModel;
//using WebMES.Utils.Cache;
//using System;
//using System.Security.Claims;
//using System.Threading;
//using System.Web;
//using WebMES.Utils.Context;

//namespace WebMES.Model.Data
//{
//    public class DTOExt : YueMES.Base.Dal.DTO
//    {
//        public DTOExt():this(null)
//        {

//        }
//        public DTOExt(string sqlText):base(sqlText)
//        { 
//        }
//        public ClaimsIdentity CurrentIdentity
//        {
//            get
//            {
//                return System.Security.Claims.ClaimsPrincipal.Current.Identity as ClaimsIdentity;  //HttpContext.Current.User.Identity as ClaimsIdentity;
//            }
//        }

//        public string UserNo
//        {
//            get
//            {
//                return WebMES.Utils.Util.DecryptDES(CurrentIdentity.Name);
                
//            }
//        }

//        public  void addThreadInfo(string dbNo)
//        {

//            if (!AppCache.ContainsKey(Thread.CurrentThread.ManagedThreadId))
//            {
//                RequestHeaderInfo info = new RequestHeaderInfo("02",dbNo);
             
//                AppCache.Add(Thread.CurrentThread.ManagedThreadId, info);

//            }
//        }
       
        

//    }
//}
