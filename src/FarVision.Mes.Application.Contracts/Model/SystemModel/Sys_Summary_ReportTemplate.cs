using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using YueMES.Data.Services;
using YueMES.Data.Business;

namespace WebMES.Model.SystemModel
{
    public class Sys_Summary_ReportTemplates : YueMES.Base.Dal.DTO
    {

        #region 初始化
        /// <summary>
        /// 从表sys_Summary中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Summary_ReportTemplates(string SqlString)
            : base(SqlString)
        {
            this.Refresh();
        }
        #endregion
        #region 私有的方法
        #endregion
        #region 公开的属性
        #endregion
        #region 公开的方法
        /// <summary>
        /// 获取某一行的数据对象
        /// </summary>
        public new Sys_Summary_ReportTemplate this[int index] { get { return ((Sys_Summary_ReportTemplate)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Summary_ReportTemplate(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Summary_ReportTemplate); }
        #endregion
        #region 静态方法
        private static Sys_Summary_ReportTemplates m_Default;
        public static Sys_Summary_ReportTemplates Default
        {
            get
            {
                if (m_Default != null) return m_Default;
                m_Default = new Sys_Summary_ReportTemplates(string.Format("select * from Sys_Summary_ReportTemplate"));
                m_Default.TableName = "Sys_Summary_ReportTemplate";
                return m_Default;
            }
        }
        internal static void SetDefaultNull()
        {
            m_Default = null;
        }
        public static Sys_Summary_ReportTemplate GetItem(int id)
        {
            Sys_Summary_ReportTemplate result = (Sys_Summary_ReportTemplate)Default.FindRow("ID", id);
            return result;
        }

        public void SaveTemplet(string busiNo, string category, byte[] byte_Current)
        {
            DataRow dr = this.FindRow("Category", category);
            if (dr == null)
            {
                dr = this.NewRow();
                this.Rows.Add(dr);
                dr["ID"] = -1;
            }
            dr["BusiNo"] = busiNo;
            dr["UserID"] = Sys_User.m_LoginUserID;
            dr["Category"] = category;
            dr["ViewData"] = byte_Current;
            dr["IsDefault"] = false;
        }
        #endregion
    }

    /// <summary>
    /// 系统汇总记录
    /// </summary>
    public class Sys_Summary_ReportTemplate : YueMES.Base.Dal.DRO
    {

        #region 初始化
        /// <summary>
        /// 初始化sys_Summary对象
        /// </summary>
        internal protected Sys_Summary_ReportTemplate(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 对应数据表字段的属性
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return (int)this["ID"]; } set { this["ID"] = value; } }
        /// <summary>
        /// 业务编号
        /// </summary>
        public string BusiNo { get { return (string)this["BusiNo"]; } set { this["BusiNo"] = value; } }
        /// <summary>
        /// 标识符
        /// </summary>
        public string Category { get { return (string)this["Category"]; } set { this["Category"] = value; } }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get { return (int)this["UserID"]; } set { this["UserID"] = value; } }
        /// <summary>
        /// 报表文件
        /// </summary>
        public byte[] ViewData { get { return (byte[])this["ViewData"]; } set { this["ViewData"] = value; } }
        /// <summary>
        /// 是否默认
        /// </summary>
        public bool IsDefault { get { return (bool)this["IsDefault"]; } set { this["IsDefault"] = value; } }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get { return (string)this["Remark"] ?? ""; } set { this["Remark"] = value; } }
        #endregion
        #region 公开的属性
        #endregion
        #region 公开的方法
        #endregion
        #region 静态方法
        #endregion
    }
}
