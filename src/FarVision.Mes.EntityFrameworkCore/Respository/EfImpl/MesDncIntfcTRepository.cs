using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MesDncIntfcTRepository : EfCoreRepository<MesDbContext,MesDncIntfcT, int >, IMesDncIntfcTRepository
	{
		public MesDncIntfcTRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}