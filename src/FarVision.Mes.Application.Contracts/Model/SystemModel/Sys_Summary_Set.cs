using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using YueMES.Data.Business;
using YueMES.Data.Services;
using YueMES.Base.Config;
namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 系统汇总记录设置集合
    /// </summary>
    public class Sys_Summary_Sets : YueMES.Base.Dal.DTO
    {
        #region 初始化
        /// <summary>
        /// 从表Sys_Summary_Set中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Summary_Sets(string SqlString)
            : base(SqlString)
        {
            this.Refresh();
            this.Columns["ID"].AutoIncrement = true;
        }
        #endregion
        #region 公开的方法
        /// <summary>
        /// 获取某一行的数据对象
        /// </summary>
        public new Sys_Summary_Set this[int index] { get { return ((Sys_Summary_Set)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Summary_Set(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Summary_Set); }
        /// <summary>
        /// 保存合并设置
        /// </summary>
        /// <param name="busiNo">业务编号</param>
        /// <param name="si">Sys_Summary_Item对象</param>
        /// <returns>DataRowSaveResult</returns>
        public DataRowSaveResult SaveDB(string busiNo, Sys_Summary_Item si)
        {
            byte[] byt = StoreBase.GetBytes(si).Value;
            DataRow dr = this.FindRow("BusiNo", busiNo);
            if (dr == null) { dr = this.NewRow(); this.Rows.Add(dr); }
            dr["UserID"] = Sys_User.m_LoginUserID;
            dr["BusiNo"] = busiNo;
            dr["SummaryObject"] = byt;
            bf_Busi bb = bf_Busis.GetItem("Sys_Summary_Set");
            DataRowSaveResult drsr = null;
            if (dr.RowState == DataRowState.Added) drsr = bb.DataRowInsert(dr);
            if (dr.RowState == DataRowState.Modified) drsr = bb.DataRowUpdate(dr);
            if (drsr.Success) { dr.AcceptChanges(); return null; }
            dr.RejectChanges();
            return drsr;
        }
        #endregion
        #region 静态方法
        private static Sys_Summary_Sets m_Default;
        public static Sys_Summary_Sets Default
        {
            get
            {
                if (m_Default != null) return m_Default;
                m_Default = new Sys_Summary_Sets(string.Format("select * from sys_Summary_Set where UserID={0}", Sys_User.m_LoginUserID));
                m_Default.TableName = "sys_Summary_Set";
                return m_Default;
            }
        }
        internal static void SetDefaultNull()
        {
            m_Default = null;
        }
        #endregion
    }

    /// <summary>
    /// 系统汇总记录设置
    /// </summary>
    public class Sys_Summary_Set : YueMES.Base.Dal.DRO
    {
        #region 私有的方法
        /// <summary>
        /// 初始化Sys_Summary_Set对象
        /// </summary>
        internal protected Sys_Summary_Set(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 对应数据表字段的属性
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return (int)this["ID"]; } }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get { return (int)this["UserID"]; } }
        /// <summary>
        /// 业务编号
        /// </summary>
        public string BusiNo { get { return (string)this["BusiNo"]; } }
        /// <summary>
        /// 设置对象
        /// </summary>
        public byte[] SummaryObject { get { return (byte[])this["SummaryObject"]; } }
        #endregion
    }

    /// <summary>
    /// 系统汇总记录项
    /// </summary>
    [Serializable()]
    public class Sys_Summary_Item : YueMES.Base.Config.StoreItem
    {
        public Sys_Summary_Item()
        {

        }
        /// <summary>
        /// 分组对象集合
        /// </summary>
        public List<string> GroupFileds
        {
            get
            {
                List<string> result = (List<string>)this.GetItemValue("GroupFileds", null);
                if (result == null) result = new List<string>();
                this.GroupFileds = result;
                return result;
            }
            set { this.SetItemValue("GroupFileds", value, true); }
        }
        /// <summary>
        /// 合计对象集合
        /// </summary>
        public List<Sys_Summary_ItemDetail> SummaryItems
        {
            get
            {
                List<Sys_Summary_ItemDetail> result = (List<Sys_Summary_ItemDetail>)this.GetItemValue("SummaryItems", null);
                if (result == null) result = new List<Sys_Summary_ItemDetail>();
                this.SummaryItems = result;
                return result;
            }
            set { this.SetItemValue("SummaryItems", value, true); }
        }
    }

    [Serializable()]
    public class Sys_Summary_ItemDetail
    {
        /// <summary>
        /// 合计列，排列顺序号
        /// </summary>
        public int FieldIndex { get; set; }
        /// <summary>
        /// 合计列，列名
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// 合计列，合计类型
        /// </summary>

    }
}
