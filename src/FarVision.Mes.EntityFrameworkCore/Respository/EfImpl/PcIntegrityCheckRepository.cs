using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcIntegrityCheckRepository : EfCoreRepository<MesDbContext,PcIntegrityCheck, int >, IPcIntegrityCheckRepository
	{
		public PcIntegrityCheckRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}