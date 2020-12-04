using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VQcPrdInspectFirstRepository : EfCoreRepository<MesDbContext,VQcPrdInspectFirst, int >, IVQcPrdInspectFirstRepository
	{
		public VQcPrdInspectFirstRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}