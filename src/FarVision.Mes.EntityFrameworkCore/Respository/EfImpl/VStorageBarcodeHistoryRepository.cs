using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VStorageBarcodeHistoryRepository : EfCoreRepository<MesDbContext,VStorageBarcodeHistory, int >, IVStorageBarcodeHistoryRepository
	{
		public VStorageBarcodeHistoryRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}