using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbPrdtParasRepository : EfCoreRepository<MesDbContext,SbPrdtParas, int >, ISbPrdtParasRepository
	{
		public SbPrdtParasRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}