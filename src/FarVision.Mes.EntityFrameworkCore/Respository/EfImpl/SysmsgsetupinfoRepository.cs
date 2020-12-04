using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysmsgsetupinfoRepository : EfCoreRepository<MesDbContext,Sysmsgsetupinfo, int >, ISysmsgsetupinfoRepository
	{
		public SysmsgsetupinfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}