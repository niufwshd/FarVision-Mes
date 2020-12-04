using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysmsgconfigRepository : EfCoreRepository<MesDbContext,Sysmsgconfig, int >, ISysmsgconfigRepository
	{
		public SysmsgconfigRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}