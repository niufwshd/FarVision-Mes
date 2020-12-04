using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysInterfaceQueueRepository : EfCoreRepository<MesDbContext,SysInterfaceQueue, int >, ISysInterfaceQueueRepository
	{
		public SysInterfaceQueueRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}