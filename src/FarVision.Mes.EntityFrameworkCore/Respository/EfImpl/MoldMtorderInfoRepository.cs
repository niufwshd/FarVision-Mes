using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldMtorderInfoRepository : EfCoreRepository<MesDbContext,MoldMtorderInfo, int >, IMoldMtorderInfoRepository
	{
		public MoldMtorderInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}