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
using WebMES.Model.UNModels.Model;

namespace WebMES.Model.UNModels
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

            string requestBody = content.Request.JsonSerializer.Serialize(PostObj);
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
                DataRowsSaveResult drsr = bd.SaveToDB(null, null);
            }
            else
            {
                var ResponseCode = string.Empty;
                var ResponseMessage = string.Empty;
                var ZGUID = string.Empty;
                var isSendMialToSAP = false;//是否发送邮件 added by haijun 2018-4-18
                try
                {
                    BaseReturnModel model = Newtonsoft.Json.JsonConvert.DeserializeObject<BaseReturnModel>(responseBody);
                    if (model == null) throw new ApplicationException("返回信息解析失败：" + InterfaceURL["Url"].ToString() + "->" + responseBody);
                    if (content.Data == null) content.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);

                    //added by haijun
                    if (model.HEAD != null)
                    {
                        if (!String.IsNullOrEmpty(model.HEAD.ZTYPE))
                        {
                            if (model.HEAD.ZTYPE == "E")
                            {
                                isSendMialToSAP = true;
                            }
                        }
                    }
                    if (model.ITEM != null && model.ITEM.Count > 0 && !isSendMialToSAP)
                    {
                        var items = model.ITEM.Where(i => i.ZTYPE == "E");
                        if (items.Any())
                        {
                            isSendMialToSAP = true;
                        }
                    }

                    if (model.HEAD != null && !string.IsNullOrEmpty(model.HEAD.ZTYPE))
                    {
                        ResponseCode = model.HEAD.ZTYPE;
                        ResponseMessage = model.HEAD.ZMESSAGE;
                        ZGUID = model.HEAD.ZGUID;
                    }
                    else if (model.ITEM != null && model.ITEM.Count > 0)
                    {
                        var items = model.ITEM.Where(i => i.ZTYPE == "E");
                        ResponseCode = items.Any() ? "E" : "S";
                        if (items.Any())
                        {
                            ResponseMessage = string.Join(";", items.Select(s => s.ZMESSAGE).ToList());
                        }
                        else
                        {
                            ResponseMessage = model.ITEM.First().ZMESSAGE;
                        }

                        ZGUID = model.ITEM.First().ZGUID;
                    }
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
                DataRowsSaveResult drsr = bd.SaveToDB(null, null);

            }

            return content;
        }


        /// <summary>
        /// 实时接口
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


            string requestBody = content.Request.JsonSerializer.Serialize(PostObj);
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
                    responseBody = responseBody.Substring(6, responseBody.Length - 8);
                    responseBody = responseBody.Replace("\\","");
                    responseBody = responseBody.Replace("/Date(", "");
                    responseBody = responseBody.Replace(")/", "");
                    responseBody = responseBody.Insert(1, "\"ZINT_ID\":\"" + interfaceCode + "\",");
                    BaseModel model = Newtonsoft.Json.JsonConvert.DeserializeObject<BaseModel>(responseBody);
                    if (model == null)
                        throw new ApplicationException("返回信息解析失败：" + InterfaceURL + "->" + responseBody);
                    if (content.Data == null)
                        content.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseBody);

                    //added by haijun
                   
                    if (model != null && !string.IsNullOrEmpty(model.ZTYPE))
                    {
                        ResponseCode = model.ZTYPE;
                        ResponseMessage = model.ZMESSAGE;
                        ZGUID = model.ZGUID;
                    }
                    //else if (model != null && model.Count > 0)
                    //{
                    //    //var items = model.ITEM.Where(i => i.ZTYPE == "E");
                    //    //ResponseCode = items.Any() ? "E" : "S";
                    //    //if (items.Any())
                    //    //{
                    //    //    ResponseMessage = string.Join(";", items.Select(s => s.ZMESSAGE).ToList());
                    //    //}
                    //    //else
                    //    //{
                    //        ResponseMessage = model.ITEM.First().ZMESSAGE;
                    //    //}

                    //    ZGUID = model.ITEM.First().ZGUID;
                    //}
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
