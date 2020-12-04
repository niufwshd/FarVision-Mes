using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Utils.Extensions
{
    public static class ReportUserFunction
    {
        /// <summary>
        /// 是否已经注册自定义函数
        /// </summary>
        public static bool IsRegisterFunction = false;
        public static string Split(string strToSplit, string splitStr, int strIndex)
        {
            if (string.IsNullOrEmpty(strToSplit)) return null;
            if (string.IsNullOrEmpty(splitStr)) return strToSplit;
            var sps = strToSplit.Split(new string[] { splitStr }, StringSplitOptions.RemoveEmptyEntries);
            if (sps.Length > strIndex)
                return sps[strIndex];
            else
                return sps[0];
        }
    }
}
