using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VProduceFeedFirstInFirstOutRepository : EfCoreRepository<MesDbContext,VProduceFeedFirstInFirstOut, int >, IVProduceFeedFirstInFirstOutRepository
	{
		public VProduceFeedFirstInFirstOutRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}