using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOnShelfGuideItemRepository : EfCoreRepository<MesDbContext,WmOnShelfGuideItem, int >, IWmOnShelfGuideItemRepository
	{
		public WmOnShelfGuideItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}