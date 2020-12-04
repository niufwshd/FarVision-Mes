using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class AlertMessageHisTRepository : EfCoreRepository<MesDbContext,AlertMessageHisT, int >, IAlertMessageHisTRepository
	{
		public AlertMessageHisTRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}