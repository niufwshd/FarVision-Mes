using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TbCpmxrbRepository : EfCoreRepository<MesDbContext,TbCpmxrb, int >, ITbCpmxrbRepository
	{
		public TbCpmxrbRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}