using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmFixtureFaultCauseRepository : EfCoreRepository<MesDbContext,MdmFixtureFaultCause, int >, IMdmFixtureFaultCauseRepository
	{
		public MdmFixtureFaultCauseRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}