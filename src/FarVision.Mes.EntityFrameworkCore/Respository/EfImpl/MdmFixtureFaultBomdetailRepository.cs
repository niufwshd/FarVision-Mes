using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmFixtureFaultBomdetailRepository : EfCoreRepository<MesDbContext,MdmFixtureFaultBomdetail, int >, IMdmFixtureFaultBomdetailRepository
	{
		public MdmFixtureFaultBomdetailRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}