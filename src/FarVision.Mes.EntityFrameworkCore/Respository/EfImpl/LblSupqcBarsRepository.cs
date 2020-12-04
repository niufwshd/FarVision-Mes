using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class LblSupqcBarsRepository : EfCoreRepository<MesDbContext,LblSupqcBars, int >, ILblSupqcBarsRepository
	{
		public LblSupqcBarsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}