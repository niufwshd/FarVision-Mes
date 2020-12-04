using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbReworkdayhzRepository : EfCoreRepository<MesDbContext,TbReworkdayhz, int >, ITbReworkdayhzRepository
	{
		public TbReworkdayhzRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}