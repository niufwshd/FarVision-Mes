using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VRosFilterXlRepository : EfCoreRepository<MesDbContext,VRosFilterXl, int >, IVRosFilterXlRepository
	{
		public VRosFilterXlRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}