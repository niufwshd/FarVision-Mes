using System;
using System.Collections.Generic;
using System.Text;
using YueMES.Data.Lang;

namespace WebMES.Utils.Context
{
    /// <summary>
    /// 后台多语言信息
    /// </summary>
    public static class MultilingualMsg
    {

        public  static string GetMsg(string Keyno)
        {
            return LangUIDatas.Default.GetLangUIData(HttpContextExt.WorkSys, Keyno, Keyno);
        }

        public static string GetMsg(string Keyno, params object[] args)
        {
            string result= LangUIDatas.Default.GetLangUIData(HttpContextExt.WorkSys, Keyno, Keyno);
            if (args == null) return result;
            if (args.Length == 0) return result;
            try
            {
                return string.Format(result, args);
            }
            catch (Exception ex)
            {
                string paramList = "";
                foreach (object arg in args)
                {
                    paramList += string.Format("[{0}]", arg);
                }
                return string.Format(@"{0}ResKey:{1}ResValue:{2}input params list:{3}", ex.Message, Keyno, result, paramList);
            }
        }
    }
}

