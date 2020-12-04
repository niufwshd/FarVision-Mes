using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PpProductionOrdersRepository : EfCoreRepository<MesDbContext,PpProductionOrders, int >, IPpProductionOrdersRepository
	{
		public PpProductionOrdersRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}