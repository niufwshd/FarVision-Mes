using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TmpTzzmxlRepository : EfCoreRepository<MesDbContext,TmpTzzmxl, int >, ITmpTzzmxlRepository
	{
		public TmpTzzmxlRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}