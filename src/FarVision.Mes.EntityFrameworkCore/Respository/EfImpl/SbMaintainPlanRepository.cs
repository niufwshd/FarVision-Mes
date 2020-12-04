using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbMaintainPlanRepository : EfCoreRepository<MesDbContext,SbMaintainPlan, int >, ISbMaintainPlanRepository
	{
		public SbMaintainPlanRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}