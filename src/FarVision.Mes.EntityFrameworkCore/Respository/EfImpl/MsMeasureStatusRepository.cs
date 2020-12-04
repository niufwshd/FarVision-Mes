using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsMeasureStatusRepository : EfCoreRepository<MesDbContext,MsMeasureStatus, int >, IMsMeasureStatusRepository
	{
		public MsMeasureStatusRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}