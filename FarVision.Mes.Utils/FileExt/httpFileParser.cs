using YueMES.Base.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;

namespace WebMES.Utils.FileExt
{
    public static class HttpFileParser
    {

        public static BooleanValue<Stream> GetFileStream(IFormFile postFile)
        {
            try
            {
                Stream stream;
                stream = postFile.OpenReadStream();
                return new BooleanValue<Stream>(stream);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return new BooleanValue<Stream>(null,ex.Message);
            }
           
        }



        public static string ReadFile(string filePath)
        {
            string Text = "";
            //文件路径
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                    {
                        Text = sr.ReadToEnd();
                        byte[] mybyte = Encoding.UTF8.GetBytes(Text);
                        Text = Encoding.UTF8.GetString(mybyte);
                        if (string.IsNullOrEmpty(Text))
                        {
                            throw new Exception($"文件为空，请检查{filePath}");
                        }
                    }
                }
                else
                {
                    throw new Exception("文件不存在");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                throw new Exception(ex.Message);
            }
            return Text;
        }



    }


}
