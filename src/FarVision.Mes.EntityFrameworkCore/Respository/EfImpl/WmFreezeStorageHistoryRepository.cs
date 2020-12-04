using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFreezeStorageHistoryRepository : EfCoreRepository<MesDbContext,WmFreezeStorageHistory, int >, IWmFreezeStorageHistoryRepository
	{
		public WmFreezeStorageHistoryRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}