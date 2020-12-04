using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmFixtureFaultBomRepository : EfCoreRepository<MesDbContext,MdmFixtureFaultBom, int >, IMdmFixtureFaultBomRepository
	{
		public MdmFixtureFaultBomRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}