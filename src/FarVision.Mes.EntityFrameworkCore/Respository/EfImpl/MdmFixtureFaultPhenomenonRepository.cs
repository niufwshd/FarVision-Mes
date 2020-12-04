using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmFixtureFaultPhenomenonRepository : EfCoreRepository<MesDbContext,MdmFixtureFaultPhenomenon, int >, IMdmFixtureFaultPhenomenonRepository
	{
		public MdmFixtureFaultPhenomenonRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}