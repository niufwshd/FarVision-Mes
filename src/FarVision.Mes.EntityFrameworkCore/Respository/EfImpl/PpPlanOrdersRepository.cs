using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PpPlanOrdersRepository : EfCoreRepository<MesDbContext,PpPlanOrders, int >, IPpPlanOrdersRepository
	{
		public PpPlanOrdersRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}