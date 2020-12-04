using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmWorkCenterRepository : EfCoreRepository<MesDbContext,MdmWorkCenter, int >, IMdmWorkCenterRepository
	{
		public MdmWorkCenterRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}