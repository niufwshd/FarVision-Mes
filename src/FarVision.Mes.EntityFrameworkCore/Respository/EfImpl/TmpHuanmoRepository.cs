using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TmpHuanmoRepository : EfCoreRepository<MesDbContext,TmpHuanmo, int >, ITmpHuanmoRepository
	{
		public TmpHuanmoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}