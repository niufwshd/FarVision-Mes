using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SbPartchangeRecordRepository : EfCoreRepository<MesDbContext,SbPartchangeRecord, int >, ISbPartchangeRecordRepository
	{
		public SbPartchangeRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}