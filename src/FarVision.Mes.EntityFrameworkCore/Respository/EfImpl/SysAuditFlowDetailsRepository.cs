using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysAuditFlowDetailsRepository : EfCoreRepository<MesDbContext,SysAuditFlowDetails, int >, ISysAuditFlowDetailsRepository
	{
		public SysAuditFlowDetailsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}