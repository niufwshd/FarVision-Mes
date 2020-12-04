using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmBarCodeScanTempRepository : EfCoreRepository<MesDbContext,WmBarCodeScanTemp, int >, IWmBarCodeScanTempRepository
	{
		public WmBarCodeScanTempRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}