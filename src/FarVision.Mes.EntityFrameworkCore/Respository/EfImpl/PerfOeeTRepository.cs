using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PerfOeeTRepository : EfCoreRepository<MesDbContext,PerfOeeT, int >, IPerfOeeTRepository
	{
		public PerfOeeTRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}