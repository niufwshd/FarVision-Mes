using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VWkStationProcessRepository : EfCoreRepository<MesDbContext,VWkStationProcess, int >, IVWkStationProcessRepository
	{
		public VWkStationProcessRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}