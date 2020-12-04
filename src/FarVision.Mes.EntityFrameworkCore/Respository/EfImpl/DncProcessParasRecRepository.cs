using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class DncProcessParasRecRepository : EfCoreRepository<MesDbContext,DncProcessParasRec, int >, IDncProcessParasRecRepository
	{
		public DncProcessParasRecRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}