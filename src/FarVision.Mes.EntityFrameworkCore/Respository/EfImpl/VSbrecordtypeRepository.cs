using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VSbrecordtypeRepository : EfCoreRepository<MesDbContext,VSbrecordtype, int >, IVSbrecordtypeRepository
	{
		public VSbrecordtypeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}