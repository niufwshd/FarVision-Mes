using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class FixtureRlospRepository : EfCoreRepository<MesDbContext,FixtureRlosp, int >, IFixtureRlospRepository
	{
		public FixtureRlospRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}