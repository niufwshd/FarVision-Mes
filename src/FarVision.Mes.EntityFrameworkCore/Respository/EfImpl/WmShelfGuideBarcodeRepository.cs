using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmShelfGuideBarcodeRepository : EfCoreRepository<MesDbContext,WmShelfGuideBarcode, int >, IWmShelfGuideBarcodeRepository
	{
		public WmShelfGuideBarcodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}