using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFreezeStorageRepository : EfCoreRepository<MesDbContext,WmFreezeStorage, int >, IWmFreezeStorageRepository
	{
		public WmFreezeStorageRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}