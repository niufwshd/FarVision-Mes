using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmAsnItemRepository : EfCoreRepository<MesDbContext,WmAsnItem, int >, IWmAsnItemRepository
	{
		public WmAsnItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}