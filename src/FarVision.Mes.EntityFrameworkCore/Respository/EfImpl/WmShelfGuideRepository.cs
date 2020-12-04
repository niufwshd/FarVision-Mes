using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmShelfGuideRepository : EfCoreRepository<MesDbContext,WmShelfGuide, int >, IWmShelfGuideRepository
	{
		public WmShelfGuideRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}