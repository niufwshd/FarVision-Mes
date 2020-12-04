using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Services;
using YueMES.Data.Utils;
using RestSharp;
using Newtonsoft.Json;
using WebMES.Model.ERPModels.Model.ResponseModels;
using YueMES.Base.Dal;
using WebMES.Utils.Cache;
using WebMES.Utils.Context;
using System.Threading;

namespace WebMES.Model.SCMModels.Model
{
    public class BaseInterface
    {
        // 记录接口日志

        public static IRestResponse<T> PostExcute<T>(DataRow InterfaceURL, DataRow InterfaceQueue, object PostObj) where T : class, new()
        {
            if (string.IsNullOrEmpty(InterfaceURL["Url"].ToString()))
                throw new ApplicationException("接口地址未配置！");
            var client = new RestClient(InterfaceURL["Url"].ToString());
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(PostObj);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            var content = client.Execute<T>(request);

            var interfaceCode = string.Empty;
            if (InterfaceURL["Url"].ToString().Contains("="))
            {
                interfaceCode = InterfaceURL["Url"].ToString().Split('=')[1];
            }

            string requestBody = JsonConvert.SerializeObject(PostObj);
            string responseBody = content.Content;


            if (content.StatusCode != System.Net.HttpStatusCode.OK)
            {
                BDO bd = new BDO(null, null, "SYS_InterfaceLog", "1<>1");
                DataRow drBat = bd.NewRow();
                drBat["IsIn"] = 0;
                drBat["LogTime"] = DateTime.Now;
                drBat["SerialNo"] = InterfaceQueue["SerialNo"];
                drBat["FunctionName"] = InterfaceQueue["FunctionName"];
                drBat["InterfaceName"] = InterfaceQueue["InterfaceName"];
                drBat["interfaceCode"] = interfaceCode;
                drBat["RequestBody"] = requestBody;
                drBat["ResponseBody"] = responseBody;
                drBat["ResponseCode"] = "E";
                drBat["ResponseMessage"] = content.Content;
                bd.Rows.Add(drBat);
                DataRowsSaveResult drsr = bd.SaveToDB();
            }
            else
            {
                var ResponseCode = string.Empty;
                var ResponseMessage = string.Empty;
                var ZGUID = string.Empty;
                var isSendMialToSAP = false;//是否发送邮件 added by haijun 2018-4-18
                try
                {
                    T model = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);
                    if (model == null) throw new ApplicationException("返回信息解析失败：" + InterfaceURL["Url"].ToString() + "->" + responseBody);
                    if (content.Data == null) content.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);

                }
                catch (Exception ex)
                {
                    ResponseCode = "N/A";
                    ResponseMessage = string.IsNullOrEmpty(responseBody) ? ex.Message : responseBody;
                }


                BDO bd = new BDO(null, null, "SYS_InterfaceLog", "1<>1");
                DataRow drBat = bd.NewRow();
                drBat["IsIn"] = 0;
                drBat["LogTime"] = DateTime.Now;
                drBat["SerialNo"] = InterfaceQueue["SerialNo"];
                drBat["FunctionName"] = InterfaceQueue["FunctionName"];
                drBat["InterfaceName"] = InterfaceQueue["InterfaceName"];
                drBat["interfaceCode"] = interfaceCode;
                drBat["RequestBody"] = requestBody;
                drBat["ResponseBody"] = responseBody;
                drBat["ResponseCode"] = ResponseCode;
                drBat["ResponseMessage"] = string.IsNullOrEmpty(ResponseMessage) ? "" : ResponseMessage;
                bd.Rows.Add(drBat);
                DataRowsSaveResult drsr = bd.SaveToDB();

            }

            return content;
        }


        /// <summary>
        /// 实时接口 POST请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="interfaceCode"></param>
        /// <param name="interfaceName"></param>
        /// <param name="PostObj"></param>
        /// <returns></returns>
        public static IRestResponse<T> PostExcute<T>(DataRow InterfaceURLRow, string interfaceName, object PostObj) where T : class, new()
        {
            //BDOs tmpInterFaceConfig = new BDOs("SYS_InterfaceURL", "INTERFACECODE = '"+ interfaceCode+"'");
            if (InterfaceURLRow == null)
            {
                throw new ApplicationException("接口地址未配置！");
            }
            string InterfaceURL = InterfaceURLRow["URL"].ToString();

            if (string.IsNullOrEmpty(InterfaceURL))
                throw new ApplicationException("接口地址未配置！");


            string interfaceCode = InterfaceURLRow["INTERFACECODE"].ToString();
            var client = new RestClient(InterfaceURL);
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(PostObj);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            var content = client.Execute<T>(request);


            string requestBody = JsonConvert.SerializeObject(PostObj);
            requestBody = requestBody.Replace("\\\\", "\\");
            string responseBody = content.Content;

            StackTrace trace = new StackTrace();
            StackFrame frame = trace.GetFrame(1);
            MethodBase method = frame.GetMethod();
            //String className = method.ReflectedType.Name;


            if (content.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
                Task task1 = new Task(() =>
                {
                    var ai = new RequestHeaderInfo(hi.LangNo, hi.DBNo, hi.MenuNo, hi.UserNo, hi.UserName, "");
                    AppCache.Add(Thread.CurrentThread.ManagedThreadId, ai);

                    BDO bd1 = new BDO(null, null, "SYS_InterfaceLog", "1<>1");
                    DataRow drBat1 = bd1.NewRow();
                    drBat1["IsIn"] = 1;
                    drBat1["SerialNo"] = Guid.NewGuid();
                    drBat1["FunctionName"] = method.Name;
                    drBat1["InterfaceName"] = interfaceName;
                    drBat1["interfaceCode"] = interfaceCode;
                    drBat1["RequestBody"] = requestBody;
                    drBat1["ResponseBody"] = responseBody;
                    drBat1["ResponseCode"] = "E"; 
                    drBat1["ResponseMessage"] = content.Content;
                    drBat1["CREATETIME"] = DateTime.Now;
                    bd1.Rows.Add(drBat1);
                    DataRowsSaveResult drsr1 = bd1.SaveToDB();
                    if (!drsr1.Success)
                    {
                        throw new Exception(drsr1.ErrorText);
                    }

                });
                task1.Start();
                task1.Wait();

            }
            else
            {
                var ResponseCode = string.Empty;
                var ResponseMessage = string.Empty;
                var ZGUID = string.Empty;
                try
                {
                    T model = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);
                    if (model == null)
                        throw new ApplicationException("返回信息解析失败：" + InterfaceURL + "->" + responseBody);
                    if (content.Data == null)
                        content.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);

                }
                catch (Exception ex)
                {
                    ResponseCode = "N/A";
                    ResponseMessage = string.IsNullOrEmpty(responseBody) ? ex.Message : responseBody;
                }

                var hi = AppCache.GetCache<RequestHeaderInfo>(Thread.CurrentThread.ManagedThreadId);
               

                Task task1 = new Task(() =>
                {
                    var ai = new RequestHeaderInfo(hi.LangNo,hi.DBNo,hi.MenuNo,hi.UserNo,hi.UserName,"");
                    AppCache.Add(Thread.CurrentThread.ManagedThreadId, ai);

                    BDO bd1 = new BDO(null, null, "SYS_InterfaceLog", "1<>1");
                    DataRow drBat1 = bd1.NewRow();
                    drBat1["IsIn"] = 1;
                    drBat1["SerialNo"] = Guid.NewGuid();
                    drBat1["FunctionName"] = method.Name;
                    drBat1["InterfaceName"] = interfaceName;
                    drBat1["interfaceCode"] = interfaceCode;
                    drBat1["RequestBody"] = requestBody;
                    drBat1["ResponseBody"] = responseBody;
                    drBat1["ResponseCode"] = ResponseCode;
                    drBat1["ResponseMessage"] = string.IsNullOrEmpty(ResponseMessage) ? "" : ResponseMessage;
                    drBat1["CREATETIME"] = DateTime.Now;
                    bd1.Rows.Add(drBat1);
                    DataRowsSaveResult drsr1 = bd1.SaveToDB();
                    if (!drsr1.Success)
                    {
                        throw new Exception(drsr1.ErrorText);
                    }

                });
                task1.Start();
                task1.Wait();
                

            }

            return content;
        }



        /// <summary>
        /// 实时接口 PUT请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="InterfaceURLRow"></param>
        /// <param name="interfaceName"></param>
        /// <param name="PostObj"></param>
        /// <returns></returns>
        public static IRestResponse<T> PutExcute<T>(DataRow InterfaceURLRow, string interfaceName, object PostObj) where T : class, new()
        {
            //BDOs tmpInterFaceConfig = new BDOs("SYS_InterfaceURL", "INTERFACECODE = '"+ interfaceCode+"'");
            if (InterfaceURLRow == null)
            {
                throw new ApplicationException("接口地址未配置！");
            }
            string InterfaceURL = InterfaceURLRow["URL"].ToString();

            if (string.IsNullOrEmpty(InterfaceURL))
                throw new ApplicationException("接口地址未配置！");


            string interfaceCode = InterfaceURLRow["INTERFACECODE"].ToString();
            var client = new RestClient(InterfaceURL);
            var request = new RestRequest(Method.PUT) { RequestFormat = DataFormat.Json };
            request.AddJsonBody(PostObj);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            var content = client.Execute<T>(request);

            string requestBody = JsonConvert.SerializeObject(PostObj);
            requestBody = requestBody.Replace("\\\\", "\\");
            string responseBody = content.Content;

            StackTrace trace = new StackTrace();
            StackFrame frame = trace.GetFrame(1);
            MethodBase method = frame.GetMethod();
            //String className = method.ReflectedType.Name;


            if (content.StatusCode != System.Net.HttpStatusCode.OK)
            {
                BDO bd = new BDO(null, null, "SYS_InterfaceLog", "1<>1");
                DataRow drBat = bd.NewRow();
                drBat["IsIn"] = 1;
                drBat["LogTime"] = DateTime.Now;
                drBat["SerialNo"] = Guid.NewGuid();
                drBat["FunctionName"] = method.Name;
                drBat["InterfaceName"] = interfaceName;
                drBat["interfaceCode"] = interfaceCode;
                drBat["RequestBody"] = requestBody;
                drBat["ResponseBody"] = responseBody;
                drBat["ResponseCode"] = "E";

                if (string.IsNullOrEmpty(content.Content))
                    content.Content = "接口未联通";

                drBat["ResponseMessage"] = content.Content;
                bd.Rows.Add(drBat);
                DataRowsSaveResult drsr = bd.SaveToDB(null, null);
            }
            else
            {
                var ResponseCode = string.Empty;
                var ResponseMessage = string.Empty;
                var ZGUID = string.Empty;
                try
                {
                    MES2ERPResult model = Newtonsoft.Json.JsonConvert.DeserializeObject<MES2ERPResult>(responseBody);
                    if (model == null)
                        throw new ApplicationException("返回信息解析失败：" + InterfaceURL + "->" + responseBody);
                    if (content.Data == null)
                        content.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);

                }
                catch (Exception ex)
                {
                    ResponseCode = "N/A";
                    ResponseMessage = string.IsNullOrEmpty(responseBody) ? ex.Message : responseBody;
                }


                BDO bd = new BDO(null, null, "SYS_InterfaceLog", "1<>1");
                DataRow drBat = bd.NewRow();
                drBat["IsIn"] = 1;
                drBat["SerialNo"] = Guid.NewGuid();
                drBat["FunctionName"] = method.Name;
                drBat["InterfaceName"] = interfaceName;
                drBat["interfaceCode"] = interfaceCode;
                drBat["RequestBody"] = requestBody;
                drBat["ResponseBody"] = responseBody;
                drBat["ResponseCode"] = ResponseCode;
                drBat["ResponseMessage"] = string.IsNullOrEmpty(ResponseMessage) ? "" : ResponseMessage;
                bd.Rows.Add(drBat);
                DataRowsSaveResult drsr = bd.SaveToDB(null, null);

            }

            return content;
        }

        private DateTime ConvertStringToDateTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
    }
}
