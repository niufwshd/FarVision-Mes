using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysBarcodeInfoRepository : EfCoreRepository<MesDbContext,SysBarcodeInfo, int >, ISysBarcodeInfoRepository
	{
		public SysBarcodeInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}