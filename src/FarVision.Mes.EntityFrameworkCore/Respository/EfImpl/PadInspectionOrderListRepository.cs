using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PadInspectionOrderListRepository : EfCoreRepository<MesDbContext,PadInspectionOrderList, int >, IPadInspectionOrderListRepository
	{
		public PadInspectionOrderListRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}