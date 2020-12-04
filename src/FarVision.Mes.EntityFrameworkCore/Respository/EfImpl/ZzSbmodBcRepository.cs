using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class ZzSbmodBcRepository : EfCoreRepository<MesDbContext,ZzSbmodBc, int >, IZzSbmodBcRepository
	{
		public ZzSbmodBcRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}