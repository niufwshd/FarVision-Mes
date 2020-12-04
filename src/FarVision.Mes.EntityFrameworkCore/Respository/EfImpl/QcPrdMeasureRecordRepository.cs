using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcPrdMeasureRecordRepository : EfCoreRepository<MesDbContext,QcPrdMeasureRecord, int >, IQcPrdMeasureRecordRepository
	{
		public QcPrdMeasureRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}