using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpMtorderInfoRepository : EfCoreRepository<MesDbContext,EqpMtorderInfo, int >, IEqpMtorderInfoRepository
	{
		public EqpMtorderInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}