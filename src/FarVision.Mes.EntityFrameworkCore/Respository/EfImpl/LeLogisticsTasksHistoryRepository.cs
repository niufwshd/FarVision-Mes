using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class LeLogisticsTasksHistoryRepository : EfCoreRepository<MesDbContext,LeLogisticsTasksHistory, int >, ILeLogisticsTasksHistoryRepository
	{
		public LeLogisticsTasksHistoryRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}