using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmPackageBarcodeHistoryRepository : EfCoreRepository<MesDbContext,WmPackageBarcodeHistory, int >, IWmPackageBarcodeHistoryRepository
	{
		public WmPackageBarcodeHistoryRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}