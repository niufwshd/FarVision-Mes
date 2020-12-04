using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbStatusChangesRepository : EfCoreRepository<MesDbContext,SbStatusChanges, int >, ISbStatusChangesRepository
	{
		public SbStatusChangesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}