using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQcPrdInspectLast1Repository : EfCoreRepository<MesDbContext,VQcPrdInspectLast1, int >, IVQcPrdInspectLast1Repository
	{
		public VQcPrdInspectLast1Repository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}