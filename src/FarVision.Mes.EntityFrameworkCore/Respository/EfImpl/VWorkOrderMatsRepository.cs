using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VWorkOrderMatsRepository : EfCoreRepository<MesDbContext,VWorkOrderMats, int >, IVWorkOrderMatsRepository
	{
		public VWorkOrderMatsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}