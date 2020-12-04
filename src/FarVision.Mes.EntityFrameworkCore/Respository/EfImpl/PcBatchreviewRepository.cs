using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcBatchreviewRepository : EfCoreRepository<MesDbContext,PcBatchreview, int >, IPcBatchreviewRepository
	{
		public PcBatchreviewRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}