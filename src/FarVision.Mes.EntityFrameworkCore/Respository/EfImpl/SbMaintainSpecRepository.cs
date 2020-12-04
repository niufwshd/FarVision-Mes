using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbMaintainSpecRepository : EfCoreRepository<MesDbContext,SbMaintainSpec, int >, ISbMaintainSpecRepository
	{
		public SbMaintainSpecRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}