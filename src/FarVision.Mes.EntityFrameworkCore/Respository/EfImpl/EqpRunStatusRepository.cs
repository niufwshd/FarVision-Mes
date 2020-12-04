using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpRunStatusRepository : EfCoreRepository<MesDbContext,EqpRunStatus, int >, IEqpRunStatusRepository
	{
		public EqpRunStatusRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}