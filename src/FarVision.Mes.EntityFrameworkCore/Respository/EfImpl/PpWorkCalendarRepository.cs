using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PpWorkCalendarRepository : EfCoreRepository<MesDbContext,PpWorkCalendar, int >, IPpWorkCalendarRepository
	{
		public PpWorkCalendarRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}