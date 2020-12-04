using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmStorageBarcodeRepository : EfCoreRepository<MesDbContext,WmStorageBarcode, int >, IWmStorageBarcodeRepository
	{
		public WmStorageBarcodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}