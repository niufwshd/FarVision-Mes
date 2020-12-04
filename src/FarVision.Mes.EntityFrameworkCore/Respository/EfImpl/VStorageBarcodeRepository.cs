using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VStorageBarcodeRepository : EfCoreRepository<MesDbContext,VStorageBarcode, int >, IVStorageBarcodeRepository
	{
		public VStorageBarcodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}