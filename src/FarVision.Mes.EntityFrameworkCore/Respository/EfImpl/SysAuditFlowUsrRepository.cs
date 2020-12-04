using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysAuditFlowUsrRepository : EfCoreRepository<MesDbContext,SysAuditFlowUsr, int >, ISysAuditFlowUsrRepository
	{
		public SysAuditFlowUsrRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}