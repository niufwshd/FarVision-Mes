using InfluxData.Net.Common.Enums;
using InfluxData.Net.Common.Helpers;
using InfluxData.Net.Common.Infrastructure;
using InfluxData.Net.InfluxDb;
using InfluxData.Net.InfluxDb.Models;
using InfluxData.Net.InfluxDb.Models.Responses;
using Newtonsoft.Json;
using NPOI.HSSF.Record;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.DTO.Device;
using WebMES.Utils.Helper;
using YueMES.Base.Utils;

namespace WebMES.Utils.InfluxDb
{
    public class InfluxDbHelp
    {        
       public string DataBase { get; set; }
        private string LoadConfig()
        {

            Configuration MyConfiguration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
            {
                ExeConfigFilename = Path.Combine(Environment.CurrentDirectory, "InfluxDb.config")
            }, ConfigurationUserLevel.None);
            string IP = MyConfiguration.AppSettings.Settings["IPAddr"].Value;
            int Port = Int32.Parse(MyConfiguration.AppSettings.Settings["Port"].Value);
            return IP;

        }

        string _baseAddress;
        string _username;
        string _password;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="baseAddress">URL</param>
        /// <param name="userName">用户名</param>
        /// <param name="passwWord">密码</param>
        public InfluxDbHelp(string baseAddress, string userName, string passwWord)
        {
            this._baseAddress = baseAddress;
            this._username = userName;
            this._password = passwWord;
        }


        /// <summary>
        /// 读
        /// </summary>
        /// <param name="dataBase">表名</param>
        /// <param name="sql">脚本</param>
        /// <returns></returns>
        public string Query(string dataBase, string sql)
        {
            string pathAndQuery = string.Format("/query?db={0}&q={1}", dataBase, sql);
            string url = _baseAddress + pathAndQuery;

            string result = HttpHelper.Get(url, _username, _password);
            return result;
        }

        public async Task<BooleanValue<DataTable>> Query(string sql)
        {
            
            //string pathAndQuery = string.Format("/query?db={0}&q={1}", this.DataBase, sql);
            //string url = _baseAddress + pathAndQuery;
            InfluxDbClient client = new InfluxData.Net.InfluxDb.InfluxDbClient(_baseAddress, this._username, this._password, InfluxDbVersion.Latest, QueryLocation.Uri);
            var result = await client.Client.QueryAsync(sql, this.DataBase);
           
            //string result = HttpHelper.Get(url, _username, _password);

            return InfluxDataToDatatable(result.ToList());
             
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="dataBase">表名</param>
        /// <param name="sql">示例:test,tag=logs Field0=10,Field1=10,Field2=20</param>
        /// <returns></returns>
        public string Write(string dataBase, string sql)
        {
            string url = _baseAddress + string.Format("/write?db={0}", dataBase);

            string result = HttpHelper.Post(url, sql, _username, _password);
            return result;
        }

        public async Task<IInfluxDataApiResponse> WriteAsync(string dataBase,List<Point> ps)
        {
            InfluxDbClient client = new InfluxData.Net.InfluxDb.InfluxDbClient(_baseAddress, this._username, this._password, InfluxDbVersion.Latest, QueryLocation.Uri);
            return await client.Client.WriteAsync(ps, dataBase);

        }

        /// <summary>
        /// 获取世界时间时间戳
        /// </summary>
        /// <param name="targetTime">待转换时间</param>
        /// <returns></returns>
        public static long GetUTCTimeStamp(DateTime targetTime)
        {
 
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = targetTime.Subtract(dtStart);
            long dt = toNow.Ticks * 100;
            return dt;
        }

   

        //DateTime转换为时间戳
        public static long GetTimeSpan(DateTime time)
        {
            DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 0, 0, 0, 0), TimeZoneInfo.Local);
            DateTime endTime = TimeZoneInfo.ConvertTime(time, TimeZoneInfo.Local);
            return (endTime - startTime).Ticks*100;
        }
        //timeSpan转换为DateTime
        public static DateTime TimeSpanToDateTime(long span)
        {
            DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 0, 0, 0, 0), TimeZoneInfo.Local);
            return startTime.AddTicks(span/100);
        }

        public  static BooleanValue<DataTable> InfluxDataToDatatable(List<Serie> result)
        {
            if(result==null || result.Count==0) return new BooleanValue<DataTable>(null);

            DataTable dtResult = new DataTable();
            foreach (var col in result.First().Columns)
            {
                dtResult.Columns.Add(col.ToUpper());
            }
            foreach (var dtList in result.First().Values)
            {
                var nr = dtResult.NewRow();
                nr.ItemArray = dtList.ToArray();
                dtResult.Rows.Add(nr);
            }

            //InfuxdbDataModel iniModel = JsonConvert.DeserializeObject<InfuxdbDataModel>(result);

            //if (iniModel.results.Count == 0 || iniModel.results[0].series.Count==0) return new BooleanValue<DataTable>(null);
            //DataTable dtResult = new DataTable();
            //foreach (var col in iniModel.results[0].series[0].columns)
            //{
            //    dtResult.Columns.Add(col);
            //}
            //foreach(var dtList in iniModel.results[0].series[0].values)
            //{
            //    var nr= dtResult.NewRow();
            //    nr.ItemArray = dtList.ToArray();
            //    dtResult.Rows.Add(nr);
            //}



            return new BooleanValue<DataTable>(dtResult);

        }
    }
}
