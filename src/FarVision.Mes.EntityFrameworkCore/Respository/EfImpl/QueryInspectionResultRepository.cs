using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QueryInspectionResultRepository : EfCoreRepository<MesDbContext,QueryInspectionResult, int >, IQueryInspectionResultRepository
	{
		public QueryInspectionResultRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}