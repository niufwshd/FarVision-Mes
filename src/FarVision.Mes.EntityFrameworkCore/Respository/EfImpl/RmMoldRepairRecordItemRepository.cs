using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldRepairRecordItemRepository : EfCoreRepository<MesDbContext,RmMoldRepairRecordItem, int >, IRmMoldRepairRecordItemRepository
	{
		public RmMoldRepairRecordItemRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}