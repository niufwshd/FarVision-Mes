using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMES.DTO
{
    [Serializable]
    public enum FieldEditorType
    {
        #region 通用编辑器
        /// <summary>
        /// 0默认编辑器
        /// </summary>
        Dev_Default = 0,
        /// <summary>
        /// 10下拉多行文本编辑器
        /// </summary>
        Dev_MemoEx = 10,
        /// <summary>
        /// 11多行文本编辑器
        /// </summary>
        Dev_Memo = 11,
        /// <summary>
        /// 20按钮事件自行控制(15)
        /// </summary>
        Dev_Button = 20,
        /// <summary>
        /// 30
        /// </summary>
        Dev_Image = 30,
        /// <summary>
        /// 31
        /// </summary>
        Dev_Picture = 31,

        /// <summary>
        /// 40
        /// </summary>
        Dev_SpinEdit = 40,
        /// <summary>
        /// 50
        /// </summary>
        Dev_TimeEdit = 50,

        /// <summary>
        /// 60
        /// </summary>
        Dev_ComboBoxEdit=60,

        #endregion
        #region 业务
        /// <summary>
        /// 100以lookup的方式显示业务数据(数据会缓存)(26)
        /// </summary>
        GBF_Busi_Lookup = 100,
        /// <summary>
        /// 110(28)
        /// </summary>
        GBF_Busi_Lookup_Grid = 110,
        /// <summary>
        /// 120弹出窗口，即时刷新数据(17)
        /// </summary>
        GBF_Busi_Button = 120,
        /// <summary>
        /// 130弹出窗口，以树形显示业务数据(16)
        /// </summary>
        GBF_Busi_Button_Tree = 130,
        #endregion
        #region 查询
        /// <summary>
        /// 200(27)
        /// </summary>
        GBF_Query_Button = 200,
        #endregion
        #region 列表
        /// <summary>
        /// 300(21)
        /// </summary>
        GBF_List_Combo_Value = 300,
        /// <summary>
        /// 310(22)
        /// </summary>
        GBF_List_Combo_Remark = 310,
        /// <summary>
        /// 320(23)
        /// </summary>
        GBF_List_Button_Tree = 320,
        /// <summary>
        /// 350下拉编辑器(20)
        /// </summary>
        GBF_Combox = 350,
        #endregion
        #region GBF_Lookup
        /// <summary>
        /// 400(25)
        /// </summary>
        GBF_Lookup = 400,
        #endregion
    }
}
