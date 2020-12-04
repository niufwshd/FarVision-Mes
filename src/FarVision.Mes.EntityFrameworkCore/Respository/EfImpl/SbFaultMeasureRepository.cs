using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbFaultMeasureRepository : EfCoreRepository<MesDbContext,SbFaultMeasure, int >, ISbFaultMeasureRepository
	{
		public SbFaultMeasureRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}