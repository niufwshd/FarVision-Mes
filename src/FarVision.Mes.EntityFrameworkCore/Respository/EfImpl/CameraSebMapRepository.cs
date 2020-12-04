using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class CameraSebMapRepository : EfCoreRepository<MesDbContext,CameraSebMap, int >, ICameraSebMapRepository
	{
		public CameraSebMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}