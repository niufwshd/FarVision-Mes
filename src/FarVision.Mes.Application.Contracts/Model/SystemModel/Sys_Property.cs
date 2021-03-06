#region 本页代码的部分或全部由自动代码生成器生成
// 自动代码生成器简介：
// 制作语言： Microsoft Visual Basic.NET(2003)
// 作者： 郭建光
// E-Mail： GuoJianGuang154@163.com
// QQ： 40808310
// 本页代码生成时间：2008年10月03日 15:37:28
#endregion
using System;
using System.Data;
using System.ComponentModel;
using YueMES.Data.Lang;
using YueMES.Base.Utils;
using YueMES.Base.Dal;
using YueMES.Data.Services;
using WebMES.Model.Data;
using YueMES.Base.Enum;
using System.Text;
using System.Collections.Generic;
using WebMES.Utils.Context;
using System.Collections.Concurrent;
using FarVision.Mes;

namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 系统属性信息
    /// </summary>
    public class Sys_Propertys : DTOExt, IConfigCache
    {
        private static object _lock = new object();
     

        #region 初始化
        /// <summary>
        /// 从表SystemArea中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Propertys(string SqlString)
            : base(SqlString)
        {
            this.Refresh();
        }
        #endregion
       
        /// <summary>
        /// 获取某一行的数据对象
        /// </summary>
        public new Sys_Property this[int index] { get { return ((Sys_Property)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Property(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Property); }
   
        #region 静态方法
        private static AbpMemoryCache dicDefaultSql = new ConcurrentDictionary<string, string>();
        private static string Default_sql
        {
            get
            {
                var key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}";

                if (dicDefaultSql.ContainsKey(key))
                    return dicDefaultSql[key];
                string dfSql = string.Format("select * from {0}sys_Property", Consts.GBF_DB_Name);
                dicDefaultSql[key]=dfSql;
                return dfSql;


            }
        }
        //private static Sys_Propertys m_Default;
        public static Sys_Propertys Default
        {
            get
            {
                Sys_Propertys m_Default = null;

                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_Default = (Sys_Propertys)dto;
               

                if (m_Default != null) return m_Default;
                lock (_lock)
                {
                    if (m_Default == null)
                    {
                        m_Default = new Sys_Propertys(Default_sql);
                        m_Default.TableName = "Sys_Property";
                    }
                }


                if (m_Default != null && m_Default.Columns.Count > 0)
                {
                    YueMES.Base.Dal.DTO.AddInCache(Default_sql, m_Default);
                    CacheSyncServ.RegeditConfigCache(DAO.DBNo, m_Default);
                }
                else
                    m_Default = null;

                return m_Default;
            }
        }
        internal static void SetDefaultNull()
        {
            if (Default_sql!=null)
                YueMES.Base.Dal.DTO.CacheClear(Default_sql);
        }
        public static Sys_Property GetItem(int id)
        {
            Sys_Property result = (Sys_Property)Default.FindRow("ID", id);
            return result;
        }

        public static bool GetPropertyBooleanValue(string menuNo, string propertyNo)
        {
            return Convert.ToBoolean(GetPropertyValue(menuNo, propertyNo, false));
        }

        public static string GetPropertyStringValue(string menuNo, string propertyNo)
        {
            return GetPropertyValue(menuNo, propertyNo).ToString();
        }

        public static object GetPropertyValue(string menuNo, string itemName, object defaultValue)
        {
            object result = GetPropertyValue(menuNo, itemName);
            if (result == null) result = defaultValue;
            return result;
        }
        public static object GetPropertyValue(string menuNo, string itemName)
        {
            DataRow[] drs = Default.Select(string.Format("MenuNo='{0}' and ItemNo='{1}'", menuNo, itemName));
            return GetPropertyValue(menuNo, drs);
        }
        private static object GetPropertyValue(string menuNo, DataRow[] drs)
        {
            if (drs.Length == 0) return null;
            Sys_Property prop = (Sys_Property)drs[0];
            Sys_Property_Sets propsets = Sys_Property_Sets.EP;
            if (prop.IsSystem)
            {
                string sql = string.Format("select Value from sys_Property_Set where PropertyID={0} and iUserID=-1", prop.ID);
                object valuetext = YueMES.Base.Dal.DAO.Default.ExecuteScalar(sql).Value;
                if (valuetext == null) return prop.GetValue().Value;
                if (valuetext == DBNull.Value) return prop.GetValue().Value;
                DataRow drold = propsets.FindRow("PropertyID", prop.ID);
                if (drold != null) {
                    lock (_lock)
                    {
                        drold["Value"] = valuetext;
                        drold.AcceptChanges();
                    }
                }
                
                
                return prop.GetValue((string)valuetext).Value;
            }
            else
            {

                propsets = Sys_Users.GetItem(HttpContextExt.UserNo).GetProperties(menuNo);
                drs = propsets.Select(string.Format("PropertyID={0}", prop.ID));
                if (drs.Length == 0) return prop.GetValue().Value;
                string valueText = (string)drs[0]["Value"];
                object value = prop.GetValue(valueText).Value;
                if (value == null) value = prop.GetValue().Value;
                return value;
            }
        }
        #endregion

        public string BusiNo
        {
            get { return "Sys_Property"; }
        }

        public void AddRecord(System.Collections.Generic.List<int> InsList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (InsList == null || InsList.Count == 0) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in InsList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("select * from sys_Property where ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Propertys busis = (Sys_Propertys)busisData;
                    if (busis.Columns.Count != bv.Value.Columns.Count) return;
                    lock (_lock)
                    {
                        foreach (DataRow row in bv.Value.Rows)
                        {
                            busis.LoadDataRow(row, true);
                        }
                        busis.AcceptChanges();
                    }
                }
            }
        }

        

        public void RemoveRecord(System.Collections.Generic.List<int> DelList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (DelList == null || DelList.Count == 0) return;
            if (Default_sql != null)
            {
                object busisData = null;
                YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                Sys_Propertys busis = (Sys_Propertys)busisData;
                lock (_lock)
                {
                    foreach (var id in DelList)
                    {
                        DataRow[] drs = busis.Select(string.Format("ID={0}", id));
                        if (drs.Length == 0) continue;
                        busis.Rows.Remove(drs[0]);
                    }
                    busis.AcceptChanges();
                }
            }
        }

        public void UpdateRecord(System.Collections.Generic.List<int> UpdList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (UpdList == null || UpdList.Count == 0) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in UpdList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("select * from sys_Property where ID in({0})", sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Propertys busis = (Sys_Propertys)busisData;
                    if (busis.Columns.Count != bv.Value.Columns.Count) return;
                    lock (_lock)
                    {
                        foreach (var id in UpdList)
                        {
                            DataRow[] drs = busis.Select(string.Format("ID={0}", id));
                            if (drs.Length == 0) continue;
                            busis.Rows.Remove(drs[0]);
                        }
                        foreach (DataRow row in bv.Value.Rows)
                        {
                            busis.LoadDataRow(row, true);
                        }
                        busis.AcceptChanges();
                    }
                }
            }
        }
    }
    /// <summary>
    /// 系统属性记录
    /// </summary>
    public class Sys_Property : YueMES.Base.Dal.DRO
    {
        #region 私有的方法
        /// <summary>
        /// 初始化SystemArea对象
        /// </summary>
        internal protected Sys_Property(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 对应数据表字段的属性
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return Convert.ToInt32(this["ID"]); } }
        /// <summary>
        /// 属性编号
        /// </summary>
        public string ItemNo { get { return this["ItemNo"].ToString(); } }
        /// <summary>
        /// 菜单编号
        /// </summary>
        public string MenuNo { get { return this["MenuNo"].ToString(); } }
        /// <summary>
        /// 属性名称
        /// </summary>
        public string ItemName { get { return this["ItemName"].ToString(); } }
        /// <summary>
        /// 默认值
        /// </summary>
        public string ItemValue { get { return this["ItemValue"].ToString(); } }
        public string ItemValueType { get { return this["ItemValueType"].ToString(); } }
        public int ItemSort { get { return Convert.ToInt32(this["ItemSort"]); } }
        public int edit_Type { get { return Convert.ToInt32(this["edit_Type"]); } }
        public string edit_No { get { return this["edit_No"].ToString(); } }
        public string edit_Field { get { return this["edit_Field"].ToString(); } }
        public bool IsSystem { get { return this["IsSystem"]==DBNull.Value?false: Convert.ToBoolean(this["IsSystem"]); } }
        #endregion
        #region 自定义属性
        public string Caption
        {
            get { return GetCaption(this.ItemName); }
        }
        #endregion
        #region 公开的方法
        public BooleanValue<object> GetValue()
        {
            return this.GetValue(this.ItemValue);
        }
        public BooleanValue<object> GetValue(string valueText)
        {
            return GetValue(this.ItemValueType, valueText);
        }
        #endregion
        #region 静态的方法
        public static BooleanValue<object> GetValue(string typeString, string valueText)
        {
            return GetValue(typeString, valueText, null);
        }
        public static BooleanValue<object> GetValue(string typeString, string valueText, object defaultValue)
        {
            Type type = Type.GetType(typeString, false);
            TypeConverter tc = System.ComponentModel.TypeDescriptor.GetConverter(type);
            object value = null;
            try
            {
                if (typeString == "System.Boolean")
                {
                    if (valueText == "1")
                    {
                        valueText = "true";
                    }
                    else if (valueText=="0")
                    {
                        valueText = "false";

                    }
                }
                value = tc.ConvertFromString(valueText);
                return new BooleanValue<object>(value);
            }
            catch (Exception ex)
            {
                return new BooleanValue<object>(defaultValue, ex.Message);
            }
        }
        public static string GetCaption(string itemName)
        {
            string keyNo = string.Format("Property_{0}", itemName);
            string result = LangUIDatas.Default.GetLangUIData(HttpContextExt.WorkSys, keyNo, itemName);
            if (result == null) result = itemName;
            return result;
        }
        #endregion
    }
}