using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFeedingDetailRepository : EfCoreRepository<MesDbContext,WmFeedingDetail, int >, IWmFeedingDetailRepository
	{
		public WmFeedingDetailRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}