using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbRbMxMonthRepository : EfCoreRepository<MesDbContext,TbRbMxMonth, int >, ITbRbMxMonthRepository
	{
		public TbRbMxMonthRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}