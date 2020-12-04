using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class LeLogisticsTasksItemRepository : EfCoreRepository<MesDbContext,LeLogisticsTasksItem, int >, ILeLogisticsTasksItemRepository
	{
		public LeLogisticsTasksItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}