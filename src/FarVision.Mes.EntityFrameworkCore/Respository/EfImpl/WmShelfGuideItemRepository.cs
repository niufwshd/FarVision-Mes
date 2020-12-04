using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmShelfGuideItemRepository : EfCoreRepository<MesDbContext,WmShelfGuideItem, int >, IWmShelfGuideItemRepository
	{
		public WmShelfGuideItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}