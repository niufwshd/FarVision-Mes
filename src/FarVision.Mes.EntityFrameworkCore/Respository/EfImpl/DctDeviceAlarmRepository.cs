using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class DctDeviceAlarmRepository : EfCoreRepository<MesDbContext,DctDeviceAlarm, int >, IDctDeviceAlarmRepository
	{
		public DctDeviceAlarmRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}