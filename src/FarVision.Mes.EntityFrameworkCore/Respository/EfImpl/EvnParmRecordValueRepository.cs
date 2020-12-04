using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EvnParmRecordValueRepository : EfCoreRepository<MesDbContext,EvnParmRecordValue, int >, IEvnParmRecordValueRepository
	{
		public EvnParmRecordValueRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}