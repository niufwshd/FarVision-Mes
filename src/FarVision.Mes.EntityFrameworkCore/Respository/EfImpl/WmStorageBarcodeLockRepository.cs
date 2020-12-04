using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmStorageBarcodeLockRepository : EfCoreRepository<MesDbContext,WmStorageBarcodeLock, int >, IWmStorageBarcodeLockRepository
	{
		public WmStorageBarcodeLockRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}