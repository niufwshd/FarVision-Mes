using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpMtRunTimeRepository : EfCoreRepository<MesDbContext,EqpMtRunTime, int >, IEqpMtRunTimeRepository
	{
		public EqpMtRunTimeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}