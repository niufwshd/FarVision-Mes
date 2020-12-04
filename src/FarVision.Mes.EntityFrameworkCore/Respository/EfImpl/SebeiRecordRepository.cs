using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SebeiRecordRepository : EfCoreRepository<MesDbContext,SebeiRecord, int >, ISebeiRecordRepository
	{
		public SebeiRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}