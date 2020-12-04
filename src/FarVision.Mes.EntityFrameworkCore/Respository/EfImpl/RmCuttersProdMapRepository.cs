using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmCuttersProdMapRepository : EfCoreRepository<MesDbContext,RmCuttersProdMap, int >, IRmCuttersProdMapRepository
	{
		public RmCuttersProdMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}