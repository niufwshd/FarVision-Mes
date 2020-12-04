using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldRepairRequestRepository : EfCoreRepository<MesDbContext,RmMoldRepairRequest, int >, IRmMoldRepairRequestRepository
	{
		public RmMoldRepairRequestRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}