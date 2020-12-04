using IdentityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using WebMES.Utils.Cache;
using YueMES.Base.Dal;

namespace WebMES.Utils.Context
{
    public static class HttpContextExt
    {
        public static HttpContext Current => new HttpContextAccessor().HttpContext;

        //public static string UserHostAddress => Current.Features.Get<IHttpConnectionFeature>().RemoteIpAddress.ToString();
        public static string UserAgent => Current.Request.Headers["User-Agent"].ToString();

        /// <summary>
        /// 当前账号
        /// </summary>
        public static string UserNo
        {
            get
            {
                if (Current == null)
                {
                    var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                    return hi == null ? "" : hi.UserNo;
                }
                else
                {
                    var identity = Current.User.Identity as ClaimsIdentity;
                    var userClaim = identity.Claims.FirstOrDefault(x => x.Type == JwtClaimTypes.Id);
                    if (userClaim != null)
                    {
                        return userClaim.Value;
                    }
                    else
                    {
                        var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                        return hi == null ? "" : hi.UserNo;

                    }
                    
                }
            }

        }
        /// <summary>
        /// 当前账号名
        /// </summary>
        public static string UserName
        {
            get
            {
                if (Current == null)
                {
                    var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                    return hi == null ? "" : hi.UserName;
                }
                else
                {
                    var identity = Current.User.Identity as ClaimsIdentity;
                    var userClaim = identity.Claims.FirstOrDefault(x => x.Type == JwtClaimTypes.Name);
                    if (userClaim != null)
                    {
                        return userClaim.Value;
                    }
                    else
                    {
                        var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                        return hi == null ? "" : hi.UserName;

                    }
                    //return userClaim == null ? "" : userClaim.Value;
                }
            }

        }
        /// <summary>
        /// 当前会话菜单
        /// </summary>
        public static string MenuNo
        {
            get
            {
                var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                return hi == null ? "" : hi.MenuNo;
            }
        }

        /// <summary>
        /// 当前会话所属系统
        /// </summary>
        public static string WorkSys
        {
            get
            {
                if (Current == null)
                {
                    var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                    return hi == null ? "" : hi.WorkSys;
                }
                else
                {
                    var identity = Current.User.Identity as ClaimsIdentity;
                    var userClaim = identity.Claims.FirstOrDefault(x => x.Type == "WorkSys");
                    var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                    hi.WorkSys = userClaim == null ? "ALL" : userClaim.Value;
                    return hi.WorkSys;
                }

            }
        }
        /// <summary>
        /// 当前会话库编号
        /// </summary>
        public static string DbNo
        {
            get
            {
                var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                if (hi == null || string.IsNullOrEmpty(hi.DBNo)) return DBLinkDatas.Default.DefaultDbNo;
                return  hi.DBNo;
            }
        }
        /// <summary>
        /// 当前会话语言编号
        /// </summary>
        public static string LangNo
        {
            get
            {
                var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                return hi == null || string.IsNullOrEmpty(hi.LangNo) ? "02" : hi.LangNo;
            }
        }
        /// <summary>
        /// 客户端IP地址
        /// </summary>
        public static string IpAddress
        {
            get
            {
                if (Current == null)
                {
                    var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                    return hi == null ? "" : hi.MenuNo;
                }
                else
                {
                    var ipadd = Current.Connection.RemoteIpAddress.ToString();
                    if (ipadd == "::1")
                    {
                        List<string> ipList = YueMES.Base.Dev.ComputerInfo.GetIpAddress();
                        StringBuilder sbd = new StringBuilder();
                        foreach (var v in ipList)
                        {
                            sbd.Append("'");
                            sbd.Append(v);
                            sbd.Append("',");
                        }
                        if(sbd.Length>0)
                            return sbd.ToString(0, sbd.Length - 1);
                        else
                            return $"'{ipadd}'";
                    }
                    else
                    {
                        return $"'{ipadd}'";
                    }
                }

            }
        }

        public static string LocalIp
        {
            get
            {
                if (Current == null)
                {
                    return string.Empty;
                }
                else
                {
                    return Current.Connection.LocalIpAddress.ToString();
                }
            }
        }
    }




}