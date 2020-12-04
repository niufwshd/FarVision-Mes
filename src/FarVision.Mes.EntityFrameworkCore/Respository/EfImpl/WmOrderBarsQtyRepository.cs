using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOrderBarsQtyRepository : EfCoreRepository<MesDbContext,WmOrderBarsQty, int >, IWmOrderBarsQtyRepository
	{
		public WmOrderBarsQtyRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}