using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VOnTraySingleTraceRepository : EfCoreRepository<MesDbContext,VOnTraySingleTrace, int >, IVOnTraySingleTraceRepository
	{
		public VOnTraySingleTraceRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}