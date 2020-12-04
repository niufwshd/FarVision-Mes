using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpMtspecInfoRepository : EfCoreRepository<MesDbContext,EqpMtspecInfo, int >, IEqpMtspecInfoRepository
	{
		public EqpMtspecInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}