using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysAuditFlowRepository : EfCoreRepository<MesDbContext,SysAuditFlow, int >, ISysAuditFlowRepository
	{
		public SysAuditFlowRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}