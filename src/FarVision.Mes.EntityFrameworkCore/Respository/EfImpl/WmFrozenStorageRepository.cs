using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmFrozenStorageRepository : EfCoreRepository<MesDbContext,WmFrozenStorage, int >, IWmFrozenStorageRepository
	{
		public WmFrozenStorageRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}