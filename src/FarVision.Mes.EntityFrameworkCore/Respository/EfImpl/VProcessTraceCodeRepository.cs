using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VProcessTraceCodeRepository : EfCoreRepository<MesDbContext,VProcessTraceCode, int >, IVProcessTraceCodeRepository
	{
		public VProcessTraceCodeRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}