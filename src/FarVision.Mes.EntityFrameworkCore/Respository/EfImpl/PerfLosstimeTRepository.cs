using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PerfLosstimeTRepository : EfCoreRepository<MesDbContext,PerfLosstimeT, int >, IPerfLosstimeTRepository
	{
		public PerfLosstimeTRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}