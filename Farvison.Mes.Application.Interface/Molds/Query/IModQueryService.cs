using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Molds.Query
{
    public interface IModQueryService
    {
        BooleanValue<DataTable> getModBySebPrdNo(string sebNo,string prdNo);
    }
}
