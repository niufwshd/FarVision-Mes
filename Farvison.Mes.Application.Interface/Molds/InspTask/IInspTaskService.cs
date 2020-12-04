using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebMES.DTO.Mold;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Molds.InspTask
{
    public interface IInspTaskService
    {

        BooleanValue<BDOs> CreateMoldTask(string programNo, string sourceNo, string modNo, string modSN, string mastSourceBusiNo, string mastTargeBusiNo,string userExec=null,string userDept=null);

        BooleanValue<BDOs> CreateMoldTask(string modNo,string modSN, string mastSourceBusiNo, string mastTargeBusiNo,List<MoldInspTaskDto>  listProgram);

        bool CheckOutOfRange(DataRow row);
      
    }
}
