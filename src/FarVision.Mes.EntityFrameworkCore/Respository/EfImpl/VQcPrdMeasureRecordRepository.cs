using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQcPrdMeasureRecordRepository : EfCoreRepository<MesDbContext,VQcPrdMeasureRecord, int >, IVQcPrdMeasureRecordRepository
	{
		public VQcPrdMeasureRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}