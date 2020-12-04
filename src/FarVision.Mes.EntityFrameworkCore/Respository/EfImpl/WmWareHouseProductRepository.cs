using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmWareHouseProductRepository : EfCoreRepository<MesDbContext,WmWareHouseProduct, int >, IWmWareHouseProductRepository
	{
		public WmWareHouseProductRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}