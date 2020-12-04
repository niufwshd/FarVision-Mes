using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TBaseuserDeviceRepository : EfCoreRepository<MesDbContext,TBaseuserDevice, int >, ITBaseuserDeviceRepository
	{
		public TBaseuserDeviceRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}