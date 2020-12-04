using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TomesYplacebarRepository : EfCoreRepository<MesDbContext,TomesYplacebar, int >, ITomesYplacebarRepository
	{
		public TomesYplacebarRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}