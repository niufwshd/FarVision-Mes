using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MdmBomdetailRepository : EfCoreRepository<MesDbContext,MdmBomdetail, int >, IMdmBomdetailRepository
	{
		public MdmBomdetailRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}