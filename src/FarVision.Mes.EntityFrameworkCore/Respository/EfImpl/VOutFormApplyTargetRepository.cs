using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VOutFormApplyTargetRepository : EfCoreRepository<MesDbContext,VOutFormApplyTarget, int >, IVOutFormApplyTargetRepository
	{
		public VOutFormApplyTargetRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}