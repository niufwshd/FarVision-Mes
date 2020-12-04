using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOnShelfGuideBarcodeRepository : EfCoreRepository<MesDbContext,WmOnShelfGuideBarcode, int >, IWmOnShelfGuideBarcodeRepository
	{
		public WmOnShelfGuideBarcodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}