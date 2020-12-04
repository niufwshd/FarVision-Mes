using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Utils.FileExt
{
    public static class EXCELFileTools
    {

        public static void SetColumnWidth(ISheet sheet, int colsCount)
        {

            for (int columnNum = 0; columnNum <= colsCount; columnNum++)
            {
                int columnWidth = sheet.GetColumnWidth(columnNum) / 256;//获取当前列宽度  
                for (int rowNum = 0; rowNum <= sheet.LastRowNum; rowNum++)//在这一列上循环行  
                {
                    IRow currentRow = sheet.GetRow(rowNum);
                    ICell currentCell = currentRow.GetCell(columnNum);
                    if (currentCell == null) continue;
                    int length = Encoding.UTF8.GetBytes(currentCell.ToString()).Length;//获取当前单元格的内容宽度  
                    if (columnWidth < length + 1)
                    {
                        columnWidth = length + 1;
                    }//若当前单元格内容宽度大于列宽，则调整列宽为当前单元格宽度，后面的+1是我人为的将宽度增加一个字符  
                }
                sheet.SetColumnWidth(columnNum, columnWidth * 256 > 255 * 100 ? 255 * 100 : columnWidth * 256);
            }
        }

    }
}
