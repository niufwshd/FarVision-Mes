using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysAccountCloseItemRepository : EfCoreRepository<MesDbContext,SysAccountCloseItem, int >, ISysAccountCloseItemRepository
	{
		public SysAccountCloseItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}