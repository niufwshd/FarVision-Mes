using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmCycleTimeRepository : EfCoreRepository<MesDbContext,MdmCycleTime, int >, IMdmCycleTimeRepository
	{
		public MdmCycleTimeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}