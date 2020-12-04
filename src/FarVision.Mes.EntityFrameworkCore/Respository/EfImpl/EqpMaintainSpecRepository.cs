using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpMaintainSpecRepository : EfCoreRepository<MesDbContext,EqpMaintainSpec, int >, IEqpMaintainSpecRepository
	{
		public EqpMaintainSpecRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}