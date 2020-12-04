using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOutFormApplyBarcodeInfoRepository : EfCoreRepository<MesDbContext,WmOutFormApplyBarcodeInfo, int >, IWmOutFormApplyBarcodeInfoRepository
	{
		public WmOutFormApplyBarcodeInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}