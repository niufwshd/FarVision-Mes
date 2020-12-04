using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VBarcodeStorageRepository : EfCoreRepository<MesDbContext,VBarcodeStorage, int >, IVBarcodeStorageRepository
	{
		public VBarcodeStorageRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}