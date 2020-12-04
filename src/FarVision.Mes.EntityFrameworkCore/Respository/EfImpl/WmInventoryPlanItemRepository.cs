using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmInventoryPlanItemRepository : EfCoreRepository<MesDbContext,WmInventoryPlanItem, int >, IWmInventoryPlanItemRepository
	{
		public WmInventoryPlanItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}