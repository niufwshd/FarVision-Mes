using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldFaultReasonRepository : EfCoreRepository<MesDbContext,RmMoldFaultReason, int >, IRmMoldFaultReasonRepository
	{
		public RmMoldFaultReasonRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}