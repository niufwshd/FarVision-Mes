using YueMES.Base.Utils;
using WebMES.Utils;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Utils.FileExt
{
    public static class XLSFileParser
    {
        public static IWorkbook OpenWorkBook(string path)
        {
            try
            {
                string ext = Path.GetExtension(path);
                XSSFWorkbook xssfWb = null;
                HSSFWorkbook hssfWb = null;
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);

                if (ext == ".xls")
                {
                    hssfWb = new HSSFWorkbook(file);
                    file.Close();
                    file.Dispose();
                    return hssfWb;
                }
                else
                {
                    xssfWb = new XSSFWorkbook(file);
                    file.Close();
                    file.Dispose();
                    return xssfWb;
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            return null;

        }

        public static IWorkbook OpenWorkBook(Stream stream, string ext)
        {
            try
            {
                //string ext = Path.GetExtension(fileName);
                XSSFWorkbook xssfWb = null;
                HSSFWorkbook hssfWb = null;
                if (ext == ".xls")
                {
                    stream.Seek(0, SeekOrigin.Begin);   
                    hssfWb = new HSSFWorkbook(stream);
                    stream.Close();
                    stream.Dispose();
                    return hssfWb;
                }
                else
                {
                    stream.Seek(0, SeekOrigin.Begin);   
                    xssfWb = new XSSFWorkbook(stream);
                    stream.Close();
                    stream.Dispose();
                    return xssfWb;
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            return null;

        }


        public static BooleanValue<DataTable> ReadToDataTable(IWorkbook iWb, int sheetIdx, int headStartRow = 0)
        {
            if (iWb == null || sheetIdx < 0)
            {
                return new BooleanValue<DataTable>(null, "无法读取指定工作表");
            }

            ISheet sh = iWb.GetSheetAt(sheetIdx);
            IFormulaEvaluator e;
            if (iWb is XSSFWorkbook)
                e = new XSSFFormulaEvaluator(iWb);
            else
                e = new HSSFFormulaEvaluator(iWb);

            ICellStyle dateStyle = iWb.CreateCellStyle();
            IDataFormat dataformat = iWb.CreateDataFormat();
            dateStyle.DataFormat = dataformat.GetFormat("yyyy-mm-dd hh:mm:ss");
            Dictionary<string, string> dicDateFormat = new Dictionary<string, string>();
            dicDateFormat["yyyy-mm-dd hh:mm:ss"] = "";

            if (sh != null)
            {
                DataTable dtResult = new DataTable();
                IRow firstRow = sh.GetRow(headStartRow);
                if (firstRow == null)
                {
                    firstRow = sh.GetRow(sh.FirstRowNum);
                    headStartRow = sh.FirstRowNum;
                }
                int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数  

                for (int i = 0; i < cellCount; i++)
                {
                  
                    ICell cell = firstRow.GetCell(i, MissingCellPolicy.RETURN_BLANK_AS_NULL);
                    
                    if (cell == null || string.IsNullOrEmpty(cell.ToString().Trim())) continue;
                    if (dtResult.Columns.Contains(cell.ToString().Trim())) continue;
                    DataColumn column = new DataColumn(cell.ToString().Trim());
                    dtResult.Columns.Add(column);

                }
                
                int rowCount = sh.LastRowNum;
                for (int i = headStartRow + 1; i <= rowCount; i++)
                {
                    IRow row = sh.GetRow(i);

                    if (row == null) continue; //没有数据的行默认是null　
                    DataRow dataRow = null;
                    try
                    {
                        for (int j = 0; j < dtResult.Columns.Count; j++)
                        {

                            ICell cell = row.GetCell(j, MissingCellPolicy.RETURN_BLANK_AS_NULL);
                            if (dataRow == null)
                                dataRow = dtResult.NewRow();
                            if (cell == null) continue;
                           
                            if (cell.CellType == CellType.Formula)
                            {
                                if (cell.CellFormula.Contains("["))
                                {
                                    try
                                    {
                                        dataRow[dtResult.Columns[j].ColumnName] = cell.RichStringCellValue.ToString();
                                        continue;
                                    } catch { }
                                }
                                else
                                    cell = e.EvaluateInCell(cell);

                            }



                            if (cell.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell))
                            {
                                var format = cell.CellStyle.GetDataFormatString();
                                if (!dicDateFormat.ContainsKey(format))
                                {
                                    dateStyle = iWb.CreateCellStyle();
                                    dataformat = iWb.CreateDataFormat();
                                    dateStyle.DataFormat = dataformat.GetFormat(format.Replace("\\", ""));
                                    dicDateFormat[format] = "";
                                }

                                dataRow[dtResult.Columns[j].ColumnName] = cell.DateCellValue;
                            }
                            else if (cell.CellType == CellType.Numeric)
                            {
                                //if(dtResult.Columns[j].DataType != typeof(decimal))
                                //    dtResult.Columns[j].DataType = typeof(decimal);
                                dataRow[dtResult.Columns[j].ColumnName] = cell.NumericCellValue;
                            }
                            else if (cell.CellType == CellType.String)
                            {
                                if (cell.StringCellValue.ToUpper().Equals("NULL"))
                                {
                                    dataRow[dtResult.Columns[j].ColumnName] = DBNull.Value;
                                }
                                else
                                    dataRow[dtResult.Columns[j].ColumnName] = cell.StringCellValue.Trim();
                            }
                            else if (cell.CellType == CellType.Boolean)
                                dataRow[dtResult.Columns[j].ColumnName] = cell.BooleanCellValue;
                            else
                                dataRow[dtResult.Columns[j].ColumnName] = cell.StringCellValue;


                        }
                        if (dataRow != null)
                            dtResult.Rows.Add(dataRow);
                        //dtResult.Rows.Add(dataRow);
                    }
                    catch (Exception ex) {

                        LogHelper.Error(ex.Message);

                    }
                    
                }

                return new BooleanValue<DataTable>(dtResult);
            }
            return new BooleanValue<DataTable>(null);
        }

    }
}
