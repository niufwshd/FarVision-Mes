using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class GxOtherItemsRepository : EfCoreRepository<MesDbContext,GxOtherItems, int >, IGxOtherItemsRepository
	{
		public GxOtherItemsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}