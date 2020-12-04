using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmFixtureSerialNumberRepository : EfCoreRepository<MesDbContext,RmFixtureSerialNumber, int >, IRmFixtureSerialNumberRepository
	{
		public RmFixtureSerialNumberRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}