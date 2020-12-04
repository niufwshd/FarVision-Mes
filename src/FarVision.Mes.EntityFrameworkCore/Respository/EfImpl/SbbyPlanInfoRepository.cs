using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbbyPlanInfoRepository : EfCoreRepository<MesDbContext,SbbyPlanInfo, int >, ISbbyPlanInfoRepository
	{
		public SbbyPlanInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}