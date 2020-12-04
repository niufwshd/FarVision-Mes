using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmPackageBomItemsRepository : EfCoreRepository<MesDbContext,WmPackageBomItems, int >, IWmPackageBomItemsRepository
	{
		public WmPackageBomItemsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}