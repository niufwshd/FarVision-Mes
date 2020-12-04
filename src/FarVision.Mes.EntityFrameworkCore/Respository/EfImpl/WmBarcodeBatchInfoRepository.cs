using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmBarcodeBatchInfoRepository : EfCoreRepository<MesDbContext,WmBarcodeBatchInfo, int >, IWmBarcodeBatchInfoRepository
	{
		public WmBarcodeBatchInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}