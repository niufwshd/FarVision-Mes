using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldingDeviatesTRepository : EfCoreRepository<MesDbContext,MoldingDeviatesT, int >, IMoldingDeviatesTRepository
	{
		public MoldingDeviatesTRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}