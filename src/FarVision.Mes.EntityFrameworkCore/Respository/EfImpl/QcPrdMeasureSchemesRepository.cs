using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcPrdMeasureSchemesRepository : EfCoreRepository<MesDbContext,QcPrdMeasureSchemes, int >, IQcPrdMeasureSchemesRepository
	{
		public QcPrdMeasureSchemesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}