using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsMeasureInfoRepository : EfCoreRepository<MesDbContext,MsMeasureInfo, int >, IMsMeasureInfoRepository
	{
		public MsMeasureInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}