using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcWorkStationDeviceMappingRepository : EfCoreRepository<MesDbContext,PcWorkStationDeviceMapping, int >, IPcWorkStationDeviceMappingRepository
	{
		public PcWorkStationDeviceMappingRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}