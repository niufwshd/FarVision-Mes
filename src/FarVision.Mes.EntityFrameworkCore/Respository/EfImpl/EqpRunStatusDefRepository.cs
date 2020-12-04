using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpRunStatusDefRepository : EfCoreRepository<MesDbContext,EqpRunStatusDef, int >, IEqpRunStatusDefRepository
	{
		public EqpRunStatusDefRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}