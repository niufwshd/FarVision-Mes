using YueMES.Base.Dal;
using YueMES.Base.Utils;
using YueMES.Data.Business;
using YueMES.Data.DBInfo;
using YueMES.Data.Services;
using YueMES.Data.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WebMES.Model
{
    public class DataSaveHandler
    {
        private BDOs BDOS = null;
        private bool m_IsSaving;
        public static event Func<BDOs, BooleanResult> OnAfterSaveData;

        /// <summary>
        /// 保存数据前检查数据是否符合条件(事务前)
        /// </summary>
        /// <param name="drsr"></param>
        public bool DoDataSave(BDOs bdos, out string ErrMsg)
        {
            BDOS = bdos;
            ErrMsg = null;
            if (bdos.MasterBDO == null) return true;
            DataRowSaveResult drsr = new DataRowSaveResult(null, null);
            this.DoDataSave_Before(drsr);

            if (drsr.Success == false)
            {
                ErrMsg = drsr.ErrorText;
                //if (drsr.DataRow != null) this.OnLocateErrorControl(drsr);  //定位控件错误行所在
                return false;
            }
            try
            {
                this.m_IsSaving = true;

                this.DoDataSaveCore(drsr);

                if (OnAfterSaveData != null)
                {
                    BooleanResult br = OnAfterSaveData(bdos);
                    ErrMsg = br.ErrorText;
                    if (!br.Success)
                        return false;
                }

            }
            catch (Exception ex)
            {
                drsr.ErrorText = ex.Message;
                this.DoDataSave_RollBack(drsr);
               // throw ex; 
            }
            finally
            {
              
                this.m_IsSaving = false;
            }
            if (drsr.Success == false)
            {
                ErrMsg = drsr.ErrorText;
                
                //if (drsr.DataRow != null) this.OnLocateErrorControl(drsr);
                return false;
            }

            

            return true;

        }

        protected void DoDataSave_Before(DataRowSaveResult drsr)
        {
            //this.OnDataSave_BeforeCheck(drsr);
            if (drsr.Success == false) return;
            foreach (BDO bdo in this.BDOS.Tables)
            {
                this.DataSave_BeforeCheckBDO(drsr, bdo);
                if (drsr.Success == false) return;
            }
        }
        /// <summary>
        /// 保存数据前检查指定业数据是否符合条件(事务前)
        /// </summary>
        /// <param name="drsr"></param>
        /// <param name="bdo"></param>
        /// <returns></returns>
        protected void DataSave_BeforeCheckBDO(DataRowSaveResult drsr, BDO bdo)
        {
            drsr.DataRow = null;
            bf_Busi_Field[] bbf_List = (bf_Busi_Field[])bdo.Business.Fields.Select("m_ValueControl>0");
            foreach (BRO bro in bdo.Rows)
            {
                if (bro.RowState == DataRowState.Detached) continue;
                //if (drData.RowState == DataRowState.Unchanged) continue;
                drsr.DataRow = bro;
                bro.ValidFieldValues(drsr, bbf_List);
                if (drsr.Success == false) return;
               // this.OnDataSave_BeforeCheckRow(drsr);
                if (drsr.Success == false) return;
            }
            this.DataSave_BeforeCheckBDOUnique(drsr, bdo);
            if (drsr.Success == false) return;
        }

        /// <summary>
        /// 检查本表数据是否违反唯一性策略
        /// </summary>
        /// <param name="drsr"></param>
        /// <param name="bdo"></param>
        /// <returns></returns>
        private void DataSave_BeforeCheckBDOUnique(DataRowSaveResult drsr, BDO bdo)
        {
            drsr.DataRow = null;
            DataRow[] drschanged = bdo.Select(null, null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            if (drschanged.Length == 0) return;
            bf_Busi busi = bdo.Business;
            db_Object so = busi.db_Object;
            foreach (string gno in busi.UniqueGroupNos)
            {
                List<bf_Busi_Field> bbflist = busi.UniqueFields(gno);
                if (bbflist.Count == 0) continue;
                string ufText = "", ufText2 = "";
                List<string> ufList = new List<string>();
                foreach (bf_Busi_Field bbf in bbflist)
                {
                    if (bbf.DbType == DbType.Binary) continue;
                    ufList.Add(bbf.m_Name);
                    ufText += string.Format("+[{0}]", bbf.Caption);
                    if (bbf.VisibleType > 0) ufText2 += string.Format("+[{0}]", bbf.Caption);
                }
                if (string.IsNullOrEmpty(ufText2) == false) ufText = ufText2;
                ufText = ufText.Substring(1);
                foreach (DataRow dr in drschanged)
                {
                    drsr.DataRow = dr;
                    string filter = "";
                    foreach (bf_Busi_Field bbf in bbflist)
                    {
                        object cellValue = dr[bbf.m_Name];
                        string compareString = " is null";
                        if (cellValue != DBNull.Value) compareString = string.Format("='{0}'", cellValue);
                        filter += string.Format("and {0}{1} ", bbf.m_Name, compareString);
                    }
                    filter = filter.Substring(4);
                    int cnt = (int)bdo.Compute("Count(ID)", filter);
                    if (cnt == 1) continue;
                    string error = string.Format("表[{0}]中\r\n字段{1}违反数据唯一性策略。", busi.Caption, ufText);
                    drsr.ErrorText = error;
                    drsr.Fields = ufList;
                    return;
                }
            }
        }

        private void DoDataSaveCore(DataRowSaveResult drsr)
        {
            drsr.DataRow = null;
          
            this.OnDataSave(drsr);
            if (drsr.Success == false) { return; }
            //this.OnDataSave_BeforeCommit(drsr); /// 数据保存完成，执行后续处理工作(事务即将提交)
            if (drsr.Success == false) {  return; }
            this.BDOS.MasterBDO.AcceptChanges();
          
           //操作成功。
            this.OnDataSave_AfterCommit(drsr);
            if (drsr.Success == false) { return; }
        }

        private void DoDataSave_RollBack(BooleanResult br)
        {
            YueMES.Base.Dal.DAO.Default.RollBackTransaction();
        }
        /// <summary>
        /// 保存数据(事务中)
        /// </summary>
        /// <returns></returns>
        private void OnDataSave(DataRowSaveResult drsr) { this.SaveDataRows(drsr); }

        /// <summary>
        /// 表数据保存到数据库(事务中)
        /// </summary>
        /// <param name="drsr"></param>
        /// <returns></returns>
        private void SaveDataRows(DataRowSaveResult drsr)
        {
            drsr.DataRow = null;
            Action<object, DataRowsSaveEventArgs> dataRowsSaveHandler = new Action<object, DataRowsSaveEventArgs>(SavingDataRows);
            Action<object, DataRowSaveEventArgs> dataRowSaveHandler = new Action<object, DataRowSaveEventArgs>(SavingDataRow);
            DataRowsSaveResult drssr = this.BDOS.MasterBDO.SaveToDB(dataRowsSaveHandler, dataRowSaveHandler);
            if (drssr.Success) return;
            drsr.DataRow = drssr.DataRow;
            drsr.ErrorText = drssr.ErrorText;
            drsr.Fields = drssr.Fields;
        }
        /// <summary>
        /// 数据保存完成，执行后续处理工作(事务已经提交)
        /// </summary>
        protected virtual void OnDataSave_AfterCommit(DataRowSaveResult drsr)
        {
            OnSave_AfterTransaction(drsr, this.BDOS.MasterBDO);
        }
        private  void OnSave_AfterTransaction(DataRowSaveResult drsr, BDO bdo)
        {
            drsr.DataRow = null;
            if (bdo == null) return;
            DataRow dr = bdo.CurrentDataRow;
            if (dr == null) return;
            //if (Save_AfterTransaction == null) return;
            //DataRowSaveEventArgs drse = new DataRowSaveEventArgs(drsr, dr.RowState);
            //Save_AfterTransaction(bdo, drse);
        }

        private void SavingDataRows(object sender, DataRowsSaveEventArgs e)
        {
            //if (e.RowState == DataRowState.Added && e.ExecuteState == ExecuteState.Before) this.OnSaveDataRowsAddBefore(sender, e);
            //if (e.RowState == DataRowState.Added && e.ExecuteState == ExecuteState.After) this.OnSaveDataRowsAddAfter(sender, e);
            //if (e.RowState == DataRowState.Modified && e.ExecuteState == ExecuteState.Before) this.OnSaveDataRowsUpdateBefore(sender, e);
            //if (e.RowState == DataRowState.Modified && e.ExecuteState == ExecuteState.After) this.OnSaveDataRowsUpdateAfter(sender, e);
            //if (e.RowState == DataRowState.Deleted && e.ExecuteState == ExecuteState.Before) this.OnSaveDataRowsDeleteBefore(sender, e);
            //if (e.RowState == DataRowState.Deleted && e.ExecuteState == ExecuteState.After) this.OnSaveDataRowsDeleteAfter(sender, e);
            //if (e.Cancel) return;
        }
        private void SavingDataRow(object sender, DataRowSaveEventArgs e)
        {
            //if (e.RowState == DataRowState.Added && e.ExecuteState == ExecuteState.Before) this.OnSaveDataRowAddBefore(sender, e);
            //if (e.RowState == DataRowState.Added && e.ExecuteState == ExecuteState.After) this.OnSaveDataRowAddAfter(sender, e);
            //if (e.RowState == DataRowState.Modified && e.ExecuteState == ExecuteState.Before) this.OnSaveDataRowUpdateBefore(sender, e);
            //if (e.RowState == DataRowState.Modified && e.ExecuteState == ExecuteState.After) this.OnSaveDataRowUpdateAfter(sender, e);
            //if (e.RowState == DataRowState.Deleted && e.ExecuteState == ExecuteState.Before) this.OnSaveDataRowDeleteBefore(sender, e);
            //if (e.RowState == DataRowState.Deleted && e.ExecuteState == ExecuteState.After) this.OnSaveDataRowDeleteAfter(sender, e);
            //if (e.Cancel) return;
        }

    }
}
