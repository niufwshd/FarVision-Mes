using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldInspItemsRepository : EfCoreRepository<MesDbContext,RmMoldInspItems, int >, IRmMoldInspItemsRepository
	{
		public RmMoldInspItemsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}