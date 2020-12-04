using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQcPrdMeasureSchemesRepository : EfCoreRepository<MesDbContext,VQcPrdMeasureSchemes, int >, IVQcPrdMeasureSchemesRepository
	{
		public VQcPrdMeasureSchemesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}