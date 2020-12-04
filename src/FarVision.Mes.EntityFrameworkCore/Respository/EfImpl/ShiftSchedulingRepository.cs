using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class ShiftSchedulingRepository : EfCoreRepository<MesDbContext,ShiftScheduling, int >, IShiftSchedulingRepository
	{
		public ShiftSchedulingRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}