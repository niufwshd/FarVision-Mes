using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldMtOrderRepository : EfCoreRepository<MesDbContext,MoldMtOrder, int >, IMoldMtOrderRepository
	{
		public MoldMtOrderRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}