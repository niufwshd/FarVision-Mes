using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmCuttersLossRepository : EfCoreRepository<MesDbContext,RmCuttersLoss, int >, IRmCuttersLossRepository
	{
		public RmCuttersLossRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}