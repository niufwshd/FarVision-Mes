using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbTzrbHzRepository : EfCoreRepository<MesDbContext,TbTzrbHz, int >, ITbTzrbHzRepository
	{
		public TbTzrbHzRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}