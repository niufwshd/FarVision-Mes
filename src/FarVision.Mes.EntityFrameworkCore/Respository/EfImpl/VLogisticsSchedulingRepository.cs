using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VLogisticsSchedulingRepository : EfCoreRepository<MesDbContext,VLogisticsScheduling, int >, IVLogisticsSchedulingRepository
	{
		public VLogisticsSchedulingRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}