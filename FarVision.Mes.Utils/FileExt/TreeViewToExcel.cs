using YueMES.Base.Utils;
using YueMES.Data.Business;
using YueMES.Data.Lang;
using YueMES.Data.Query;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Utils.FileExt
{
    //树形表导出到EXCEL
    public class TreeViewToExcel
    {

        public static BooleanValue<XSSFWorkbook> TwoLeveltoExcelFile(DataTable dtMain, DataTable dtSub, string mainBusiNo, string subBusiNo,  bf_Query query,string joinCondition=null)
        {
            XSSFWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");
            IRow head = sheet.CreateRow(0);

            bf_Busi_Fields fieldsMain = bf_Busis.GetItem(mainBusiNo).Fields;
            bf_Busi_Fields fieldsSub = bf_Busis.GetItem(subBusiNo).Fields;

            //新建一个字体样式对象
            IFont font = workbook.CreateFont();
            ICellStyle headStyle = workbook.CreateCellStyle();
            //设置字体加粗样式
            font.FontHeightInPoints = 11;
            font.FontName = "微软雅黑";
            font.IsBold = true;
            //使用SetFont方法将字体样式添加到单元格样式中 
            headStyle.SetFont(font);

            ICellStyle dateStyle = workbook.CreateCellStyle();
            IDataFormat dataformat = workbook.CreateDataFormat();
            dateStyle.DataFormat = dataformat.GetFormat("yyyy-MM-dd HH:mm:ss");

            int idx = 0;
            int colsCount=0;
            foreach (bf_Busi_Field field in fieldsMain)
            {
                if (field.VisibleType != 1) continue;
                ICell headCell = head.CreateCell(idx);
                headCell.SetCellValue(field.Caption);
                headCell.CellStyle = headStyle;
                idx++;
                colsCount++;
            }
            idx = 1;
           
            string mAlias=((bf_Query_Item)query.Items.AsEnumerable().FirstOrDefault(s=>((bf_Query_Item)s).BusiNo==mainBusiNo)).Alias;
            string sAlias = ((bf_Query_Item)query.Items.AsEnumerable().FirstOrDefault(s => ((bf_Query_Item)s).BusiNo == subBusiNo)).Alias;

           // m.MRP_NO=s1.MRP_NO AND m.ID_NO=s1.BOM_NO
            string[] joinCd = !string.IsNullOrEmpty(joinCondition)?joinCondition.Replace(".","_").Split(' '):
                ((bf_Query_Item)query.Items.AsEnumerable().FirstOrDefault(s => ((bf_Query_Item)s).BusiNo == subBusiNo)).Condition.Replace(".", "_").Split(' ');
            StringBuilder sbd=new StringBuilder();
            List<string> parrentFields=new List<string>();
            foreach(var cd in joinCd){
                var items= cd.Split('=');
                if(items.Length>1)
                {
                    var pcd= items.FirstOrDefault(f=>f.ToUpper().StartsWith(mAlias.ToUpper()));
                    parrentFields.Add(pcd);
                    var ccd= items.FirstOrDefault(f=>f.ToUpper().StartsWith(sAlias.ToUpper()));
                    sbd.Append(ccd);
                    sbd.Append("='{");
                    sbd.Append(parrentFields.Count()-1);
                    sbd.Append("}'");

                }
                else
                {
                    sbd.Append(" ");
                    sbd.Append(cd);
                    sbd.Append(" ");
                }
                

            }
          
            foreach (DataRow mr in dtMain.Rows)
            {
                IRow row = sheet.CreateRow(idx);
                fillRowData(fieldsMain,mAlias, row, mr, dateStyle);
                idx++;
                head = sheet.CreateRow(idx);
                int colIdx = 1;
                foreach (bf_Busi_Field field in fieldsSub)
                {
                    if (field.VisibleType != 1) continue;
                    ICell headCell = head.CreateCell(colIdx);
                    headCell.SetCellValue(field.Caption);
                    headCell.CellStyle = headStyle;
                    colIdx++;
                }
                idx++;
                DataRow[] srs=null;
                switch (parrentFields.Count)
                {
                    case 1:
                        srs = dtSub.Select(string.Format(sbd.ToString(), mr[parrentFields[0]]));
                        break;
                    case 2:
                        srs = dtSub.Select(string.Format(sbd.ToString(), mr[parrentFields[0]], mr[parrentFields[1]]));
                        break;
                    case 3:
                        srs = dtSub.Select(string.Format(sbd.ToString(), mr[parrentFields[0]], mr[parrentFields[1]], mr[parrentFields[2]]));
                        break;
                    case 4:
                        srs = dtSub.Select(string.Format(sbd.ToString(), mr[parrentFields[0]], mr[parrentFields[1]], mr[parrentFields[2]], mr[parrentFields[3]]));
                        break;
                }
                if (srs == null) continue;
              
                foreach (DataRow sr in srs)
                {
                    row = sheet.CreateRow(idx);
                    fillRowData(fieldsSub,sAlias, row, sr, dateStyle,1);
                    idx++;
                }

            }
            EXCELFileTools.SetColumnWidth(sheet, colsCount);
            return new BooleanValue<XSSFWorkbook>(workbook);



        }

        public static void fillRowData(bf_Busi_Fields fields,string fieldAlia, IRow row, DataRow dr, ICellStyle dateStyle,int startCol=0)
        {


            int cellIdx = startCol;
            foreach (bf_Busi_Field field in fields)
            {
                if (field.VisibleType != 1) continue;
                string key = string.Format("{0}_{1}", fieldAlia, field.m_Name);
                ICell cell = row.CreateCell(cellIdx);
                cellIdx++;
               
                if (field.Editor == bf_FieldEditor.GBF_Combox)
                {
                    bf_Combox cb = bf_Comboxs.GetItem(field.edit_No);
                    bool flg = false;
                    if (cb != null)
                    {
                        DataRow[] items = bf_ComboxItems.Default.Select(string.Format("MID={0}", cb.ID));
                       // bf_Lang_Datas langs = new bf_Lang_Datas("_bf_ComboxItem", cb.No);
                        for (int j = 0; j < items.Length; j++)
                        {
                            if (items[j]["ValueText"].Equals(dr[key]))
                            {
                                cell.SetCellValue(LangDatas.Default.GetLangData("_bf_ComboxItem", cb.No, items[j]["ValueText"].ToString(), items[j]["ValueText"].ToString()));
                                flg = true;
                            }
                        }
                    }
                    if (!flg)
                    {
                        double d;
                        if (dr[key] != DBNull.Value && !string.IsNullOrEmpty(dr[key].ToString().Trim()) && double.TryParse(dr[key].ToString().Trim(), out d))
                        {
                            cell.SetCellValue(d);
                        }
                        else
                        {
                            cell.SetCellValue(dr[key].ToString());
                        }
                    }
                }
                else if (dr.Table.Columns[key].DataType == typeof(DateTime))
                {
                    if (dr[key] == DBNull.Value)
                    {
                        cell.SetCellValue("");
                    }
                    else
                    {
                        cell.SetCellValue((DateTime)dr[key]);
                    }

                    cell.CellStyle = dateStyle;
                }
                else if (dr.Table.Columns[key].DataType == typeof(bool))
                {
                    cell.SetCellValue(dr[key].ToString() == "1" || dr[key].ToString() == "Y" ? "是" : "否");
                }
                else if (dr.Table.Columns[key].DataType == typeof(Int32) || dr.Table.Columns[key].DataType == typeof(decimal) || dr.Table.Columns[key].DataType == typeof(Int64) || dr.Table.Columns[key].DataType == typeof(double))
                {
                    double d;
                    if (dr[key] != DBNull.Value && !string.IsNullOrEmpty(dr[key].ToString().Trim()) && double.TryParse(dr[key].ToString().Trim(), out d))
                    {

                        cell.SetCellValue(d);
                    }
                }
                else
                {
                    cell.SetCellValue(dr[key].ToString());
                }
            }
        }
    }
}
