using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFormBarcodeInfoRepository : EfCoreRepository<MesDbContext,WmFormBarcodeInfo, int >, IWmFormBarcodeInfoRepository
	{
		public WmFormBarcodeInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}