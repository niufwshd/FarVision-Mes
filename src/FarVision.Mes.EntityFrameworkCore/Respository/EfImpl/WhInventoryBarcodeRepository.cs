using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WhInventoryBarcodeRepository : EfCoreRepository<MesDbContext,WhInventoryBarcode, int >, IWhInventoryBarcodeRepository
	{
		public WhInventoryBarcodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}