using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Utils.DataExtend
{
   public  class DataTableAddLineNum
    {

        //DataTable自动增加序号（IDX）
        public static DataTable AddSeriNumToDataTable(DataTable dt)
        {
            //需要返回的值
            DataTable dtNew;
            if (dt.Columns.IndexOf("IDX") >= 0)
            {
                dtNew = dt;
            }
            else //添加一序号列,并且在第一列
            {
                int rowLength = dt.Rows.Count;
                int colLength = dt.Columns.Count;
                DataRow[] newRows = new DataRow[rowLength];

                dtNew = new DataTable();
                //在第一列添加“序号”列
                dtNew.Columns.Add("IDX");
                for (int i = 0; i < colLength; i++)
                {
                    dtNew.Columns.Add(dt.Columns[i].ColumnName);
                    //复制dt中的数据
                    for (int j = 0; j < rowLength; j++)
                    {
                        if (newRows[j] == null)
                            newRows[j] = dtNew.NewRow();
                        //将其他数据填充到第二列之后，因为第一列为新增的序号列
                        newRows[j][i + 1] = dt.Rows[j][i];
                    }
                }
                foreach (DataRow row in newRows)
                {
                    dtNew.Rows.Add(row);
                }

            }
            //对序号列填充，从1递增
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtNew.Rows[i]["IDX"] = i + 1;
            }
            return dtNew;
        }
    }
}
