using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmFixtureLedgerRepository : EfCoreRepository<MesDbContext,RmFixtureLedger, int >, IRmFixtureLedgerRepository
	{
		public RmFixtureLedgerRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}