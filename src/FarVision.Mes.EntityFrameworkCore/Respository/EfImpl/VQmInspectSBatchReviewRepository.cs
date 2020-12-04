using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQmInspectSBatchReviewRepository : EfCoreRepository<MesDbContext,VQmInspectSBatchReview, int >, IVQmInspectSBatchReviewRepository
	{
		public VQmInspectSBatchReviewRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}