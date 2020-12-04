using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class QmSendInspectingOrderRepository : EfCoreRepository<MesDbContext,QmSendInspectingOrder, int >, IQmSendInspectingOrderRepository
	{
		public QmSendInspectingOrderRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}