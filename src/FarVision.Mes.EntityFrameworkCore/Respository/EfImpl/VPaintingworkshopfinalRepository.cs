using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VPaintingworkshopfinalRepository : EfCoreRepository<MesDbContext,VPaintingworkshopfinal, int >, IVPaintingworkshopfinalRepository
	{
		public VPaintingworkshopfinalRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}