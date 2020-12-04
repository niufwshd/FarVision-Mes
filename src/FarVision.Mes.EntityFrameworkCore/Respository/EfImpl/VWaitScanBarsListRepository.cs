using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VWaitScanBarsListRepository : EfCoreRepository<MesDbContext,VWaitScanBarsList, int >, IVWaitScanBarsListRepository
	{
		public VWaitScanBarsListRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}