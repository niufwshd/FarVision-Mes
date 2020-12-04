using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VProductionLineAndDeviceRepository : EfCoreRepository<MesDbContext,VProductionLineAndDevice, int >, IVProductionLineAndDeviceRepository
	{
		public VProductionLineAndDeviceRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}