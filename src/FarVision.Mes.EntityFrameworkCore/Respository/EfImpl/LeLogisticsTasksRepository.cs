using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class LeLogisticsTasksRepository : EfCoreRepository<MesDbContext,LeLogisticsTasks, int >, ILeLogisticsTasksRepository
	{
		public LeLogisticsTasksRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}