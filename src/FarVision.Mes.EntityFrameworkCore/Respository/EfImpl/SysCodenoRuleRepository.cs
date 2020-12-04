using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysCodenoRuleRepository : EfCoreRepository<MesDbContext,SysCodenoRule, int >, ISysCodenoRuleRepository
	{
		public SysCodenoRuleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}