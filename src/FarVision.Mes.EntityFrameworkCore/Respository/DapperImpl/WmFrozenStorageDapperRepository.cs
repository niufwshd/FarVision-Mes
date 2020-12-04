using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFrozenStorageDapperRepository : DapperRepository<MesDbContext>, ITransientDependency
	{
		public WmFrozenStorageDapperRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}