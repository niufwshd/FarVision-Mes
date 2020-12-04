using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysAccountCloseRepository : EfCoreRepository<MesDbContext,SysAccountClose, int >, ISysAccountCloseRepository
	{
		public SysAccountCloseRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}