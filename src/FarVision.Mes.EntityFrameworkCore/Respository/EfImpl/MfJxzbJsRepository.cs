using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MfJxzbJsRepository : EfCoreRepository<MesDbContext,MfJxzbJs, int >, IMfJxzbJsRepository
	{
		public MfJxzbJsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}