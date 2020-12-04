using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQcPrdInspectLastRepository : EfCoreRepository<MesDbContext,VQcPrdInspectLast, int >, IVQcPrdInspectLastRepository
	{
		public VQcPrdInspectLastRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}