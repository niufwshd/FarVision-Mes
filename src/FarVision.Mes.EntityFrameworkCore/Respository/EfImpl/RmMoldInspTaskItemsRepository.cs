using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldInspTaskItemsRepository : EfCoreRepository<MesDbContext,RmMoldInspTaskItems, int >, IRmMoldInspTaskItemsRepository
	{
		public RmMoldInspTaskItemsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}