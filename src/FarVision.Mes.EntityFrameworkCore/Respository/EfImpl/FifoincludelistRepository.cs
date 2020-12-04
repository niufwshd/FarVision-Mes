using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class FifoincludelistRepository : EfCoreRepository<MesDbContext,Fifoincludelist, int >, IFifoincludelistRepository
	{
		public FifoincludelistRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}