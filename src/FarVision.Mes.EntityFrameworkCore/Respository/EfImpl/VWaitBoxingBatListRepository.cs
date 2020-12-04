using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VWaitBoxingBatListRepository : EfCoreRepository<MesDbContext,VWaitBoxingBatList, int >, IVWaitBoxingBatListRepository
	{
		public VWaitBoxingBatListRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}