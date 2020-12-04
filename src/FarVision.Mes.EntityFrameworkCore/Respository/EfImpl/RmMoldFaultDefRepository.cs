using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldFaultDefRepository : EfCoreRepository<MesDbContext,RmMoldFaultDef, int >, IRmMoldFaultDefRepository
	{
		public RmMoldFaultDefRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}