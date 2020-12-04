using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMeasuringLedgerRepository : EfCoreRepository<MesDbContext,RmMeasuringLedger, int >, IRmMeasuringLedgerRepository
	{
		public RmMeasuringLedgerRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}