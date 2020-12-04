using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmBarcodeBatchInfoHisRepository : EfCoreRepository<MesDbContext,WmBarcodeBatchInfoHis, int >, IWmBarcodeBatchInfoHisRepository
	{
		public WmBarcodeBatchInfoHisRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}