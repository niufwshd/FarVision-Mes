using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysmsgsetupRepository : EfCoreRepository<MesDbContext,Sysmsgsetup, int >, ISysmsgsetupRepository
	{
		public SysmsgsetupRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}