using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOnShelfGuideRuleRepository : EfCoreRepository<MesDbContext,WmOnShelfGuideRule, int >, IWmOnShelfGuideRuleRepository
	{
		public WmOnShelfGuideRuleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}