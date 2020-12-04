using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmOutFormApplyRepository : EfCoreRepository<MesDbContext,WmOutFormApply, int >, IWmOutFormApplyRepository
	{
		public WmOutFormApplyRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}