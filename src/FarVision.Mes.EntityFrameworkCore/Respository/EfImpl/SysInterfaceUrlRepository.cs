using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysInterfaceUrlRepository : EfCoreRepository<MesDbContext,SysInterfaceUrl, int >, ISysInterfaceUrlRepository
	{
		public SysInterfaceUrlRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}