using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqpPartChangeRecordRepository : EfCoreRepository<MesDbContext,EqpPartChangeRecord, int >, IEqpPartChangeRecordRepository
	{
		public EqpPartChangeRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}