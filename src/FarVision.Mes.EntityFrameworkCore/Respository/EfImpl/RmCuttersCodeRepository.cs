using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmCuttersCodeRepository : EfCoreRepository<MesDbContext,RmCuttersCode, int >, IRmCuttersCodeRepository
	{
		public RmCuttersCodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}