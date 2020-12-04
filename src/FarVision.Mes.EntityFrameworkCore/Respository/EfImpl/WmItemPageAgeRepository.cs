using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmItemPageAgeRepository : EfCoreRepository<MesDbContext,WmItemPageAge, int >, IWmItemPageAgeRepository
	{
		public WmItemPageAgeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}