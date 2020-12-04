using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EvnParmRecordRepository : EfCoreRepository<MesDbContext,EvnParmRecord, int >, IEvnParmRecordRepository
	{
		public EvnParmRecordRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}