using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class DncAlarmRecRepository : EfCoreRepository<MesDbContext,DncAlarmRec, int >, IDncAlarmRecRepository
	{
		public DncAlarmRecRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}