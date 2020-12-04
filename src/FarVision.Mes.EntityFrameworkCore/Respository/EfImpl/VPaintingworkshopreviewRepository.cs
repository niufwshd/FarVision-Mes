using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VPaintingworkshopreviewRepository : EfCoreRepository<MesDbContext,VPaintingworkshopreview, int >, IVPaintingworkshopreviewRepository
	{
		public VPaintingworkshopreviewRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}