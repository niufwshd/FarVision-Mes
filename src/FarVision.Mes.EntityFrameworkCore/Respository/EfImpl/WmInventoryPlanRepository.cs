using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmInventoryPlanRepository : EfCoreRepository<MesDbContext,WmInventoryPlan, int >, IWmInventoryPlanRepository
	{
		public WmInventoryPlanRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}