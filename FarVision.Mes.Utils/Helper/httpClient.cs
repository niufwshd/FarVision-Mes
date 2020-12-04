using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WebMES.Utils.Helper
{
    public static class HttpRequestClient
    {

        private static void SetHeaders(HttpWebRequest request, List<KeyValuePair<string, string>> HeaderPairs)
        {
            if (HeaderPairs == null) return;
            foreach(var pa in HeaderPairs)
            {
                request.Headers.Add(pa.Key, pa.Value);
            }

        }
        public static string HttpPost(string Url, string jsonData,List<KeyValuePair<string,string>> HeaderPairs=null)
        {


            try
            {
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Timeout = 60000;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json;charset=UTF-8";

                SetHeaders(request, HeaderPairs);

                byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);
                request.ContentLength = byteArray.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);
                newStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.Default);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            catch (WebException ex)
            {

                if (ex.Response != null)
                {
                    HttpWebResponse res = (HttpWebResponse)ex.Response;

                    StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.Default);
                    throw new Exception(sr.ReadToEnd());
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }




        }

        public static string HttpGet(string Url, List<KeyValuePair<string, string>> HeaderPairs = null)
        {
            try
            {
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "GET";
                request.Timeout = 60000;
                request.ContentType = "application/json;charset=UTF-8";
                SetHeaders(request, HeaderPairs);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch (WebException ex)
            {

                if (ex.Response != null)
                {
                    HttpWebResponse res = (HttpWebResponse)ex.Response;

                    StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8);
                    throw new Exception(sr.ReadToEnd());
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public static string HttpGet(string Url, int timeOut, List<KeyValuePair<string, string>> HeaderPairs = null)
        {
            try
            {
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "GET";
                request.Timeout = timeOut;
                request.ContentType = "application/json;charset=UTF-8";
                SetHeaders(request, HeaderPairs);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch (WebException ex)
            {

                if (ex.Response != null)
                {
                    HttpWebResponse res = (HttpWebResponse)ex.Response;

                    StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8);
                    throw new Exception(sr.ReadToEnd());
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }

        }


        public static byte[] HttpDownLoadStream(string Url,List<KeyValuePair<string, string>> HeaderPairs = null)
        {

            try
            {
               
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                SetHeaders(request, HeaderPairs);

                request.AddRange(0, 10000000);
                byte[] buffers = null;


                using (Stream stream = request.GetResponse().GetResponseStream())
                {
                    MemoryStream ms = new MemoryStream();

                    //建立字节组，并设置它的大小是多少字节
                    byte[] buffer = new byte[102400];

                    int readBytes = stream.Read(buffer, 0, buffer.Length);

                    while (readBytes > 0)
                    {
                        ms.Write(buffer, 0, readBytes);
                        readBytes = stream.Read(buffer, 0, buffer.Length);
                    }

                    buffers = ms.ToArray();
                    ms.Close();
                    ms.Dispose();
                }
                return buffers;
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    HttpWebResponse res = (HttpWebResponse)wex.Response;

                    StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8);

                    throw new Exception(sr.ReadToEnd());
                }
                else
                {
                    throw new Exception(wex.Message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static byte[] HttpPostAndDownLoadStream(string Url, string jsonData, List<KeyValuePair<string, string>> HeaderPairs = null)
        {

            try
            {
                
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                request.Timeout = 60000;
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json;charset=UTF-8";

                SetHeaders(request, HeaderPairs);

                byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);
                request.ContentLength = byteArray.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);
                newStream.Close();
                request.AddRange(0, 10000000);
                byte[] buffers = null;


                using (Stream stream = request.GetResponse().GetResponseStream())
                {
                    MemoryStream ms = new MemoryStream();

                    //建立字节组，并设置它的大小是多少字节
                    byte[] buffer = new byte[102400];

                    int readBytes = stream.Read(buffer, 0, buffer.Length);

                    while (readBytes > 0)
                    {
                        ms.Write(buffer, 0, readBytes);
                        readBytes = stream.Read(buffer, 0, buffer.Length);
                    }

                    buffers = ms.ToArray();
                    ms.Close();
                    ms.Dispose();
                }
                return buffers;
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    HttpWebResponse res = (HttpWebResponse)wex.Response;

                    StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8);
                    throw new Exception(sr.ReadToEnd());
                }
                else
                {
                    throw new Exception(wex.Message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
