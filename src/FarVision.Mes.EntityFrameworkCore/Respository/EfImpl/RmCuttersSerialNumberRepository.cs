using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmCuttersSerialNumberRepository : EfCoreRepository<MesDbContext,RmCuttersSerialNumber, int >, IRmCuttersSerialNumberRepository
	{
		public RmCuttersSerialNumberRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}