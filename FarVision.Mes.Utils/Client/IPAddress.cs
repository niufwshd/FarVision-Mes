using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WebMES.Utils.Client
{
    public class ClientIpAdd
    {
        public static string IPAddress
        {get;
            //get
            //{
            //    string result = String.Empty;
            //    result = WebMES.Utils.Context.HttpContext.Current.["HTTP_X_FORWARDED_FOR"];
            //    if (result != null && result != String.Empty)
            //    {
            //        //可能有代理
            //        if (result.IndexOf(".") == -1)    //没有“.”肯定是非IPv4格式
            //            result = null;
            //        else
            //        {
            //            if (result.IndexOf(",") != -1)
            //            {
            //                //有“,”，估计多个代理。取第一个不是内网的IP。
            //                result = result.Replace(" ", "").Replace("'", "");
            //                string[] temparyip = result.Split(",;".ToCharArray());
            //                for (int i = 0; i < temparyip.Length; i++)
            //                {
            //                    if (IsIPAddress(temparyip[i])
            //                        && temparyip[i].Substring(0, 3) != "10."
            //                        && temparyip[i].Substring(0, 7) != "192.168"
            //                        && temparyip[i].Substring(0, 7) != "172.16.")
            //                    {
            //                        return temparyip[i];    //找到不是内网的地址
            //                    }
            //                }
            //            }
            //            else if (IsIPAddress(result)) //代理即是IP格式 ,IsIPAddress判断是否是IP的方法,
            //                return result;
            //            else
            //                result = null;    //代理中的内容 非IP，取IP
            //        }

            //    }
                
            //    string IpAddress = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            //    if (null == result || result == String.Empty)
            //        result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            //    if (result == null || result == String.Empty)
            //        result = HttpContext.Current.Request.UserHostAddress;

            //    return result;
            //}
        }

        public static bool IsIPAddress(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length < 7 || str.Length > 15)
                return false;

            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}{1}quot;";

            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);

            return regex.IsMatch(str);
        }

    }
}
