using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldRepairRecordReasonRepository : EfCoreRepository<MesDbContext,RmMoldRepairRecordReason, int >, IRmMoldRepairRecordReasonRepository
	{
		public RmMoldRepairRecordReasonRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}