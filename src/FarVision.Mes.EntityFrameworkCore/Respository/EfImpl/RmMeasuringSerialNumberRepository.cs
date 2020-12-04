using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMeasuringSerialNumberRepository : EfCoreRepository<MesDbContext,RmMeasuringSerialNumber, int >, IRmMeasuringSerialNumberRepository
	{
		public RmMeasuringSerialNumberRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}