using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmMaterialPreparaPlanRepository : EfCoreRepository<MesDbContext,WmMaterialPreparaPlan, int >, IWmMaterialPreparaPlanRepository
	{
		public WmMaterialPreparaPlanRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}