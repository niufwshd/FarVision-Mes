using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PadInspectionOrderCategoryTotalQtyRepository : EfCoreRepository<MesDbContext,PadInspectionOrderCategoryTotalQty, int >, IPadInspectionOrderCategoryTotalQtyRepository
	{
		public PadInspectionOrderCategoryTotalQtyRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}