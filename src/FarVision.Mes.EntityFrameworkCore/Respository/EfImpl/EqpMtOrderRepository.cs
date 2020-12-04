using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpMtOrderRepository : EfCoreRepository<MesDbContext,EqpMtOrder, int >, IEqpMtOrderRepository
	{
		public EqpMtOrderRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}