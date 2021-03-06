#region 本页代码的部分或全部由自动代码生成器生成
// 自动代码生成器简介：
// 制作语言： Microsoft Visual Basic.NET(2003)
// 作者： 郭建光
// E-Mail： GuoJianGuang154@163.com
// QQ： 40808310
// 本页代码生成时间：2008年10月03日 15:37:28
#endregion
using YueMES.Base.Dal;
using YueMES.Base.Utils;
using YueMES.Data.Services;
using WebMES.Model.Data;
using System;
using System.Data;
using System.Text;


namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Sys_Role_Menus : DTOExt, IConfigCache
    {

        private object _lock = new object();
        #region 初始化
        /// <summary>
        /// 从表SystemArea中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Role_Menus(string SqlString)
            : base(SqlString)
        {
            BooleanResult br = this.Refresh();
            if (br.Success)
            {

                if (!string.IsNullOrEmpty(SqlString) && this.Columns.Count > 0)
                {
                    YueMES.Base.Dal.DTO.AddInCache(SqlString, this);
                    CacheSyncServ.RegeditConfigCache(DAO.DBNo, this, SqlString);
                }
                return;
            }
        }
        #endregion
        #region 私有的方法
        #endregion
        #region 公开的属性
        #region 自定义属性
        #endregion
        #endregion
        #region 公开的方法
        /// <summary>
        /// 获取某一行的数据对象
        /// </summary>
        public new Sys_Role_Menu this[int index] { get { return ((Sys_Role_Menu)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Role_Menu(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Role_Menu); }
        #endregion
        #region 静态方法
        #endregion

        public void AddRecord(System.Collections.Generic.List<int> InsList, YueMES.Base.Dal.DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (InsList == null || InsList.Count == 0 || string.IsNullOrEmpty(CacheKey)) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in InsList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("{0} and ma.ID in({1})",CacheKey, sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (CacheKey != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(CacheKey, DBNo, out busisData);
                    if (busisData == null) return;
                    Sys_Role_Menus busis = (Sys_Role_Menus)busisData;
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

        public string BusiNo
        {
            get { return "sys_Role_Menu"; }
        }

        public void RemoveRecord(System.Collections.Generic.List<int> DelList, YueMES.Base.Dal.DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (DelList == null || DelList.Count == 0 || string.IsNullOrEmpty(CacheKey)) return;
            if (CacheKey != null)
            {
                object busisData = null;
                YueMES.Base.Dal.DTO.TryGetCache( CacheKey, DBNo, out busisData);
                if (busisData == null) return;
                Sys_Role_Menus busis = (Sys_Role_Menus)busisData;
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

        public void UpdateRecord(System.Collections.Generic.List<int> UpdList, YueMES.Base.Dal.DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (UpdList == null || UpdList.Count == 0 || string.IsNullOrEmpty(CacheKey)) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in UpdList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("{0} and ma.ID in({1})", CacheKey, sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (CacheKey != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(CacheKey, DBNo, out busisData);
                    if (busisData == null) return;
                    Sys_Users busis = (Sys_Users)busisData;
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
    /// 
    /// </summary>
    public class Sys_Role_Menu
    {
        #region 私有的方法
        /// <summary>
        /// 初始化SystemArea对象
        /// </summary>
        internal protected Sys_Role_Menu(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 公开的属性
        #region 对应数据表字段的属性
        //, , sFormType, iDefaultQueryCount, iControlSpace, iControlColumn, bCreateLookUp, bSyncLookUp, sTableName, 
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID 
        /// <summary>
        /// 角色ID
        /// </summary>
        public int MID { get { return Convert.ToInt32(this["MID"]); } }
        /// <summary>
        /// 菜单编号
        /// </summary>
        public string MenuNo { get { return this["MenuNo"].ToString(); } }
        /// <summary>
        /// 数据查看：
        /// 0 禁用，
        /// 10 本人，
        /// 20 本角色，
        /// 30 角色及下属，
        /// 40 全部，
        /// </summary>
        public int iView { get { return Convert.ToInt32(this["iView"]); } }
        /// <summary>
        /// 数据修改：
        /// 0 禁用，
        /// 10 本人，
        /// 20 本角色，
        /// 30 角色及下属，
        /// 40 全部，
        /// </summary>
        public int iEdit { get { return Convert.ToInt32(this["iEdit"]); } }
        /// <summary>
        /// 数据删除：
        /// 0 禁用，
        /// 10 本人，
        /// 20 本角色，
        /// 30 角色及下属，
        /// 40 全部，
        /// </summary>
        public int iDelete { get { return Convert.ToInt32(this["iDelete"]); } }
        public bool iAdd { get { return Convert.ToBoolean(this["iAdd"]); } }
        public bool iPrint { get { return Convert.ToBoolean(this["iPrint"]); } }
        public bool iExport { get { return Convert.ToBoolean(this["iExport"]); } }
        public bool iProperty { get { return Convert.ToBoolean(this["iProperty"]); } }
        
    }
}