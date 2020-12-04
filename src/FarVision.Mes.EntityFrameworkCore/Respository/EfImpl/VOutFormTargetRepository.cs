using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VOutFormTargetRepository : EfCoreRepository<MesDbContext,VOutFormTarget, int >, IVOutFormTargetRepository
	{
		public VOutFormTargetRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}