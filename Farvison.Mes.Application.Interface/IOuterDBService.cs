using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.Config;

namespace Farvison.Mes.Application.Interface
{
    public interface IOuterDBService
    {
        OuterDbInfo GetOuterDbConnectionByNo(string no);
        Task<OuterDbInfo> GetOuterDbConnectionByNoAsync(string no);
    }
}
