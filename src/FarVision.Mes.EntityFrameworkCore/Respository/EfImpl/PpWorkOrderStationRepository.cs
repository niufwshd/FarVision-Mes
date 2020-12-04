using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PpWorkOrderStationRepository : EfCoreRepository<MesDbContext,PpWorkOrderStation, int >, IPpWorkOrderStationRepository
	{
		public PpWorkOrderStationRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}