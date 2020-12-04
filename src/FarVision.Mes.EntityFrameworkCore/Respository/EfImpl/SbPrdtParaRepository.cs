using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbPrdtParaRepository : EfCoreRepository<MesDbContext,SbPrdtPara, int >, ISbPrdtParaRepository
	{
		public SbPrdtParaRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}