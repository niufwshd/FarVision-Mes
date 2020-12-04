using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TDevicebindlogRepository : EfCoreRepository<MesDbContext,TDevicebindlog, int >, ITDevicebindlogRepository
	{
		public TDevicebindlogRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}