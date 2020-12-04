using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcPrdMeasureSchemesItemRepository : EfCoreRepository<MesDbContext,QcPrdMeasureSchemesItem, int >, IQcPrdMeasureSchemesItemRepository
	{
		public QcPrdMeasureSchemesItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}