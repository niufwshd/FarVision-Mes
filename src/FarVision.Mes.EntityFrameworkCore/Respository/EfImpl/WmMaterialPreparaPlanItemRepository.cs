using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmMaterialPreparaPlanItemRepository : EfCoreRepository<MesDbContext,WmMaterialPreparaPlanItem, int >, IWmMaterialPreparaPlanItemRepository
	{
		public WmMaterialPreparaPlanItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}