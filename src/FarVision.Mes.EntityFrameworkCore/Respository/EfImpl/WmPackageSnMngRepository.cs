using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmPackageSnMngRepository : EfCoreRepository<MesDbContext,WmPackageSnMng, int >, IWmPackageSnMngRepository
	{
		public WmPackageSnMngRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}