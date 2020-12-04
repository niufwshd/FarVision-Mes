using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QcPrdInspectSchemesRepository : EfCoreRepository<MesDbContext,QcPrdInspectSchemes, int >, IQcPrdInspectSchemesRepository
	{
		public QcPrdInspectSchemesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}