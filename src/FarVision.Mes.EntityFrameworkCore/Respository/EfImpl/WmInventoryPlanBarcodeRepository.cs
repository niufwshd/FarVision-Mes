using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmInventoryPlanBarcodeRepository : EfCoreRepository<MesDbContext,WmInventoryPlanBarcode, int >, IWmInventoryPlanBarcodeRepository
	{
		public WmInventoryPlanBarcodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}