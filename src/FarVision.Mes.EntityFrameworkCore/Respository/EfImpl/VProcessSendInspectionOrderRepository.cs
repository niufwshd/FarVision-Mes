using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VProcessSendInspectionOrderRepository : EfCoreRepository<MesDbContext,VProcessSendInspectionOrder, int >, IVProcessSendInspectionOrderRepository
	{
		public VProcessSendInspectionOrderRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}