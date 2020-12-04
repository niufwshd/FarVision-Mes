using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbMtorderInfoRepository : EfCoreRepository<MesDbContext,SbMtorderInfo, int >, ISbMtorderInfoRepository
	{
		public SbMtorderInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}