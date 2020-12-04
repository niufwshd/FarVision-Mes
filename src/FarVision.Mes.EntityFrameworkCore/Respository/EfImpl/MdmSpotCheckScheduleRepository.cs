using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmSpotCheckScheduleRepository : EfCoreRepository<MesDbContext,MdmSpotCheckSchedule, int >, IMdmSpotCheckScheduleRepository
	{
		public MdmSpotCheckScheduleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}