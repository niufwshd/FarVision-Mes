using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbMtRuntimeRepository : EfCoreRepository<MesDbContext,SbMtRuntime, int >, ISbMtRuntimeRepository
	{
		public SbMtRuntimeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}