using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VPackageAndStorageRepository : EfCoreRepository<MesDbContext,VPackageAndStorage, int >, IVPackageAndStorageRepository
	{
		public VPackageAndStorageRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}