using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PpWorkOrderMatsRepository : EfCoreRepository<MesDbContext,PpWorkOrderMats, int >, IPpWorkOrderMatsRepository
	{
		public PpWorkOrderMatsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}