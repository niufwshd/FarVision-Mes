using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbTzrbMxMonthRepository : EfCoreRepository<MesDbContext,TbTzrbMxMonth, int >, ITbTzrbMxMonthRepository
	{
		public TbTzrbMxMonthRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}