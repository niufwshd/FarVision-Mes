using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysMenuLocalSetRepository : EfCoreRepository<MesDbContext,SysMenuLocalSet, int >, ISysMenuLocalSetRepository
	{
		public SysMenuLocalSetRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}