using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldMaintainPlanRepository : EfCoreRepository<MesDbContext,MoldMaintainPlan, int >, IMoldMaintainPlanRepository
	{
		public MoldMaintainPlanRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}