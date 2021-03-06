using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmCuttersUseRepository : EfCoreRepository<MesDbContext,RmCuttersUse, int >, IRmCuttersUseRepository
	{
		public RmCuttersUseRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}