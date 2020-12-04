using Dapper;
using Dapper.FastCrud;
using FarVision.Mes.EntityFrameworkCore;
using Farvison.Mes.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;
using WebMES.Model.Config;

namespace FarVision.Mes
{
    public class OuterDB: IOuterDBService
    {
        private  IDapperRepository _dapperRepository;
        public OuterDB(IDapperRepository dapperRepository)
        {
            _dapperRepository = dapperRepository;
        }
        public  OuterDbInfo GetOuterDbConnectionByNo(string no)
        {
            var sql = "select ConnString,DataBase_Type from sys_OuterDB_ConnString where no=@no";
            var result = _dapperRepository.DbConnection.QueryFirstOrDefault<OuterDbInfo>(sql, new { no = no });
            return result;
        }
        public async Task<OuterDbInfo> GetOuterDbConnectionByNoAsync(string no)
        {
            var sql = "select ConnString,DataBase_Type from sys_OuterDB_ConnString where no=@no";
            return await _dapperRepository.DbConnection.QueryFirstOrDefaultAsync<OuterDbInfo>(sql, new { no = no });
        }
    }
}
