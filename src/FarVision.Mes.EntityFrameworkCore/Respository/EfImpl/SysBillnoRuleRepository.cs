using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysBillnoRuleRepository : EfCoreRepository<MesDbContext,SysBillnoRule, int >, ISysBillnoRuleRepository
	{
		public SysBillnoRuleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}