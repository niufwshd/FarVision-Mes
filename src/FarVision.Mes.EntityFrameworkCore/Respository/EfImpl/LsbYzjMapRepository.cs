using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class LsbYzjMapRepository : EfCoreRepository<MesDbContext,LsbYzjMap, int >, ILsbYzjMapRepository
	{
		public LsbYzjMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}