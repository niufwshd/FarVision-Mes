using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysInterfaceLogRepository : EfCoreRepository<MesDbContext,SysInterfaceLog, int >, ISysInterfaceLogRepository
	{
		public SysInterfaceLogRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}