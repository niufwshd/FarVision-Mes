using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MfJxzbSzRepository : EfCoreRepository<MesDbContext,MfJxzbSz, int >, IMfJxzbSzRepository
	{
		public MfJxzbSzRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}