using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysBarcodeRuleRepository : EfCoreRepository<MesDbContext,SysBarcodeRule, int >, ISysBarcodeRuleRepository
	{
		public SysBarcodeRuleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}