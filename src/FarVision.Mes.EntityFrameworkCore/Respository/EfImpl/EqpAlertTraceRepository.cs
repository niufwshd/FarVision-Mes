using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpAlertTraceRepository : EfCoreRepository<MesDbContext,EqpAlertTrace, int >, IEqpAlertTraceRepository
	{
		public EqpAlertTraceRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}