using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StTdcodeBusiRecordRepository : EfCoreRepository<MesDbContext,StTdcodeBusiRecord, int >, IStTdcodeBusiRecordRepository
	{
		public StTdcodeBusiRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}