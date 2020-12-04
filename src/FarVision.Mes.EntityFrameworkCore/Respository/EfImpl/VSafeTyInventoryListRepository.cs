using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VSafeTyInventoryListRepository : EfCoreRepository<MesDbContext,VSafeTyInventoryList, int >, IVSafeTyInventoryListRepository
	{
		public VSafeTyInventoryListRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}