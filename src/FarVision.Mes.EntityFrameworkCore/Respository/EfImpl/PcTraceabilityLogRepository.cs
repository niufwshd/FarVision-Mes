using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcTraceabilityLogRepository : EfCoreRepository<MesDbContext,PcTraceabilityLog, int >, IPcTraceabilityLogRepository
	{
		public PcTraceabilityLogRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}