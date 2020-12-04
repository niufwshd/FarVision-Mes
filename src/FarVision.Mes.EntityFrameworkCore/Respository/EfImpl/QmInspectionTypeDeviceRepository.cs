using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QmInspectionTypeDeviceRepository : EfCoreRepository<MesDbContext,QmInspectionTypeDevice, int >, IQmInspectionTypeDeviceRepository
	{
		public QmInspectionTypeDeviceRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}