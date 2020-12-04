using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldRepairRequestItemRepository : EfCoreRepository<MesDbContext,RmMoldRepairRequestItem, int >, IRmMoldRepairRequestItemRepository
	{
		public RmMoldRepairRequestItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}