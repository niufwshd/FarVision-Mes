using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysTerminalItemsRepository : EfCoreRepository<MesDbContext,SysTerminalItems, int >, ISysTerminalItemsRepository
	{
		public SysTerminalItemsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}