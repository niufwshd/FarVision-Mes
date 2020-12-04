using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsFlowStatusRepository : EfCoreRepository<MesDbContext,MsFlowStatus, int >, IMsFlowStatusRepository
	{
		public MsFlowStatusRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}