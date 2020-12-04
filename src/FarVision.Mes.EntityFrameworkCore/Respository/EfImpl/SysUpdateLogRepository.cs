using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysUpdateLogRepository : EfCoreRepository<MesDbContext,SysUpdateLog, int >, ISysUpdateLogRepository
	{
		public SysUpdateLogRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}