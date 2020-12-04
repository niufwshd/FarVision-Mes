using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MfUnqcRecordRepository : EfCoreRepository<MesDbContext,MfUnqcRecord, int >, IMfUnqcRecordRepository
	{
		public MfUnqcRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}