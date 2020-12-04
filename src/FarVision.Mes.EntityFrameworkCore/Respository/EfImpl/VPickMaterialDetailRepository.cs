using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VPickMaterialDetailRepository : EfCoreRepository<MesDbContext,VPickMaterialDetail, int >, IVPickMaterialDetailRepository
	{
		public VPickMaterialDetailRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}