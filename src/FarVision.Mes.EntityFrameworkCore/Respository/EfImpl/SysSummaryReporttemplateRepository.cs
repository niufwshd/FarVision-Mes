using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysSummaryReporttemplateRepository : EfCoreRepository<MesDbContext,SysSummaryReporttemplate, int >, ISysSummaryReporttemplateRepository
	{
		public SysSummaryReporttemplateRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}