using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbTzrbMxRepository : EfCoreRepository<MesDbContext,TbTzrbMx, int >, ITbTzrbMxRepository
	{
		public TbTzrbMxRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}