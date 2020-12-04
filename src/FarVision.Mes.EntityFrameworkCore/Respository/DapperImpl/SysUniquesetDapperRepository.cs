using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysUniquesetDapperRepository : DapperRepository<MesDbContext>, ITransientDependency
	{
		public SysUniquesetDapperRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}