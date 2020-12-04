using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VPaintingworkshoppreprocessRepository : EfCoreRepository<MesDbContext,VPaintingworkshoppreprocess, int >, IVPaintingworkshoppreprocessRepository
	{
		public VPaintingworkshoppreprocessRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}