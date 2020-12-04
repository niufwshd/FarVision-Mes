using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOutFormApplyItemRepository : EfCoreRepository<MesDbContext,WmOutFormApplyItem, int >, IWmOutFormApplyItemRepository
	{
		public WmOutFormApplyItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}