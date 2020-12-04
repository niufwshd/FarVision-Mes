using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmWorkCenterMapRepository : EfCoreRepository<MesDbContext,MdmWorkCenterMap, int >, IMdmWorkCenterMapRepository
	{
		public MdmWorkCenterMapRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}