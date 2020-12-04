using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class CmmMeasureRecRepository : EfCoreRepository<MesDbContext,CmmMeasureRec, int >, ICmmMeasureRecRepository
	{
		public CmmMeasureRecRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}