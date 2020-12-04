using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TfUnqcRecordRepository : EfCoreRepository<MesDbContext,TfUnqcRecord, int >, ITfUnqcRecordRepository
	{
		public TfUnqcRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}