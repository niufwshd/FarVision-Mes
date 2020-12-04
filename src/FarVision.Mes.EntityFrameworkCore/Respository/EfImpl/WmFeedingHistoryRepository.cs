using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFeedingHistoryRepository : EfCoreRepository<MesDbContext,WmFeedingHistory, int >, IWmFeedingHistoryRepository
	{
		public WmFeedingHistoryRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}