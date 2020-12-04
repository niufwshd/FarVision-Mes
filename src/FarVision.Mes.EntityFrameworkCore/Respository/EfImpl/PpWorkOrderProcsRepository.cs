using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PpWorkOrderProcsRepository : EfCoreRepository<MesDbContext,PpWorkOrderProcs, int >, IPpWorkOrderProcsRepository
	{
		public PpWorkOrderProcsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}