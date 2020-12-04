using YueMES.Base.Dal;
using YueMES.Base.Enum;
using WebMES.DTO.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using YueMES.Base.Dev;
using System.Runtime.Serialization.Formatters.Binary;

namespace WebMES.Utils
{
     public static class Util
    {

        public static bool ByteEquals(byte[] b1, byte[] b2)
        {
            if (b1.Length != b2.Length) return false;
            if (b1 == null || b2 == null) return false;
            for (int i = 0; i < b1.Length; i++)
                if (b1[i] != b2[i])
                    return false;
            return true;
        }
        public static object DefaultForType(Type targetType)
        {
            if (targetType == typeof(string)) return "";
            if (targetType == typeof(DateTime)) return DateTime.Now;
            if (targetType == typeof(bool)) return 0;
            return targetType.IsValueType ? Activator.CreateInstance(targetType) : null;

        }

        public static DataTable SetRowsState(RowStatesDTO rowstates,DataTable dt)
        {
            DataTable dtCopy = dt.Clone();
            dtCopy.TableName = dt.TableName;
            foreach (DataRow row in dt.Rows)
            {
                StateInfo stInfo = null;
                stInfo = rowstates.RowsStates.FirstOrDefault(f => f.RowID.Equals(row[rowstates.KeyFieldName]));
                if(stInfo==null) continue;
                DataRow nr = dtCopy.NewRow();
                nr.ItemArray = row.ItemArray;
                dtCopy.Rows.Add(nr);
                if (stInfo.RowState == DataRowState.Unchanged)
                {
                    nr.AcceptChanges();  
                }
                else if (stInfo.RowState == DataRowState.Modified)
                {
                    DataRow newrow = dt.NewRow();
                    newrow.ItemArray = nr.ItemArray;

                    foreach (var v in stInfo.ColsInfos)
                    {
                        nr[v.FieldName] = v.OldValue;
                    }
                    nr.AcceptChanges();
                    nr.ItemArray = newrow.ItemArray;
                }
                else if (stInfo.RowState == DataRowState.Deleted)
                {
                    nr.Delete();
                }
            }
            return dtCopy;
        
        }

        /// <summary>
        /// DES 加密
        /// </summary>
        /// <param name="desString">待加密字符串</param>
        /// <param name="key">密钥</param>
        /// <returns>加密后的字符串</returns>
        private static string EncryptDES(string desString, string key)
        {
            string result;

            try
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                byte[] bytes = new PasswordDeriveBytes(key, null).GetBytes(8);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, provider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
                byte[] buffer = Encoding.Unicode.GetBytes(desString);
                cs.Write(buffer, 0, buffer.Length);
                cs.FlushFinalBlock();
                result = Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception e)
            {
                throw new Exception("(EncryptDES Failed) " + e.Message);
            }

            return result;
        }

        /// <summary>
        /// DES 加密
        /// </summary>
        /// <param name="desString">待加密字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string EncryptDES(string desString)
        {
            string key = ConfigurationManager.AppSettings["CookieDesKey"];
            return EncryptDES(desString, key);
        }

        /// <summary>
        /// DES 解密
        /// </summary>
        /// <param name="desString">待解密字符串</param>
        /// <param name="key">密钥</param>
        /// <returns>解密后的字符串</returns>
        private static string DecryptDES(string desString, string key)
        {
            string result;

            try
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                byte[] bytes = new PasswordDeriveBytes(key, null).GetBytes(8);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, provider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write);
                byte[] buffer = Convert.FromBase64String(desString);
                cs.Write(buffer, 0, buffer.Length);
                cs.FlushFinalBlock();
                result = Encoding.Unicode.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
                throw new Exception("(DecryptDES Failed) " + e.Message);
            }

            return result;
        }

        /// <summary>
        /// DES 解密
        /// </summary>
        /// <param name="desString">待解密字符串</param>
        /// <returns>解密后的字符串</returns>
        public static string DecryptDES(string desString)
        {
            string key = ConfigurationManager.AppSettings["CookieDesKey"];
            return DecryptDES(desString, key);
        }

        /// <summary>
        /// 防注入
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string SecurityFilterHtml(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return content;
            else
            {
                content = content.Replace("<", "＜").Replace(">", "＞");

                content = content.Replace("'", "''");
                content = content.Replace("%", "[%]");
                content = content.Replace("../", "");

            }
            return content;
        }

        /// <summary>
        /// 防止前端script注入
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string SecurityFilterScript(string content)
        {
            if (string.IsNullOrWhiteSpace(content)) return content;
            else content = content.Replace("<", "＜").Replace(">", "＞");
            return content;
        }

        public static String RestoreUrl(String url)
        {
          
            //进行解码  
            url = url.Replace("_col_", ":")
            .Replace("_slash_", "/")
            .Replace("_backslash_", "\\")
            .Replace("_blank_", " ")
            .Replace("_question_", "?")
            .Replace("_equal_", "=")
            .Replace("_semicolon_", ";")
            .Replace("_lt_", "<")
            .Replace("_mt_", ">")
            .Replace("_neq_", "<>")
            .Replace(";", "")
            .Replace("_strike_","-")
            .Replace("_poundsign_","#")
            .Replace("_perc_","%");



            if (DAO.Default!=null && DAO.Default.dataBaseType == DataBaseType.Oracle)
                url = url.Replace("''", "' '");
            return url;
        }

        public static void CopyDataRowValues(DataRow drSrc, DataRow drDes, params string[] fieldPairs)
        {
            if (drSrc == null) return;
            if (drDes == null) return;
            foreach (string fieldPare in fieldPairs)
            {
                string[] fields = fieldPare.Split(',');
                if (fields.Length != 2) continue;
                if (!drDes.Table.Columns.Contains(fields[1])) continue;
                drDes[fields[1]] = drSrc[fields[0]];
            }
        }
        public static string AsciiToString(string ascii)
        {
            string returnValue = "";
            string[] split = ascii.Split(',');
            foreach (string s in split)
            {
                returnValue += Encoding.ASCII.GetString(new byte[] { (byte)int.Parse(s) });
            }
            return returnValue;
        }

        public static string DeleteUnVisibleChar(string sourceString)
        {
            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder(131);
            for (int i = 0; i < sourceString.Length; i++)
            {
                int Unicode = sourceString[i];
                if (Unicode > 16 && Unicode!=20)
                {
                    sBuilder.Append(sourceString[i].ToString());
                }
            }
            return sBuilder.ToString();
        }

        //stream 转为byte[] 
        public static byte[] stream2byte(Stream stream)
        {
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            return buffer;
        }
        //byte[] 转stream
        public static Stream byte2stream(byte[] buffer)
        {
            Stream stream = new MemoryStream(buffer);
            stream.Seek(0, SeekOrigin.Begin);
            //设置stream的position为流的开始
            return stream;
        }

        public static byte[] Serialize(object data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream rems = new MemoryStream();
            formatter.Serialize(rems, data);
            return rems.GetBuffer();
        }

        public static string RepeatString(string str, int n)
        {
            char[] arr = str.ToCharArray();

            char[] arrDest = new char[arr.Length * n];

            for (int i = 0; i < n; i++)
            {
                Buffer.BlockCopy(arr, 0, arrDest, i * arr.Length * 2, arr.Length * 2);
            }

            return new string(arrDest);

        }
        #region 硬件信息
        private static List<string> m_Hard_Macs = null;
        public static List<string> Hard_Macs
        {
            get
            {
                if (m_Hard_Macs != null) return m_Hard_Macs;
                m_Hard_Macs = ComputerInfo.GetMACList();
                return m_Hard_Macs;
            }
        }
        private static string m_Hard_MacDefault = null;
        public static string Hard_MacDefault
        {
            get
            {
                if (m_Hard_MacDefault != null) return m_Hard_MacDefault;
                m_Hard_MacDefault = "";
                foreach (string mac in Hard_Macs)
                {
                    if (mac.Trim() == "") continue;
                    m_Hard_MacDefault = mac;
                    break;
                }
                return m_Hard_MacDefault;
            }
        }
        private static string m_Hard_Cpu = null;
        public static string Hard_Cpu
        {
            get
            {
                if (m_Hard_Cpu != null) return m_Hard_Cpu;
                m_Hard_Cpu = ComputerInfo.GetDefalutCpuID();
                return m_Hard_Cpu;
            }
        }
        private static string m_Hard_Disk = null;
        public static string Hard_Disk
        {
            get
            {
                if (m_Hard_Disk != null) return m_Hard_Disk;
                m_Hard_Disk = ComputerInfo.GetDefalutHardDiskID();
                return m_Hard_Disk;
            }
        }
        #endregion

        public static string GetFileHash(string fileName)
        {
            if (File.Exists(fileName) == false) return string.Empty;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var MD5 = System.Security.Cryptography.MD5.Create();
            byte[] hashBytes = MD5.ComputeHash(fs);
            fs.Close();
            return ToHexString(hashBytes);
        }
        internal static string ToHexString(byte[] buf)
        {
            string result = BitConverter.ToString(buf);
            result = result.Replace("-", "");
            return result;
        }

        public static string GetObjectHash(object obj)
        {
            var bytes = Serialize(obj);
            return ToHexString(bytes);
        }
    }
}
