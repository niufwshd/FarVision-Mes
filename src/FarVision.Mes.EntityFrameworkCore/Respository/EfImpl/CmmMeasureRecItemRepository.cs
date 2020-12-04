using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class CmmMeasureRecItemRepository : EfCoreRepository<MesDbContext,CmmMeasureRecItem, int >, ICmmMeasureRecItemRepository
	{
		public CmmMeasureRecItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}