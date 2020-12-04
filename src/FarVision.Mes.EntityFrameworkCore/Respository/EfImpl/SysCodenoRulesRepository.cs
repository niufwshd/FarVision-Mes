using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysCodenoRulesRepository : EfCoreRepository<MesDbContext,SysCodenoRules, int >, ISysCodenoRulesRepository
	{
		public SysCodenoRulesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}