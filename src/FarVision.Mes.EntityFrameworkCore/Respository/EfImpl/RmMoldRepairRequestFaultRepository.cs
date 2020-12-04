using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldRepairRequestFaultRepository : EfCoreRepository<MesDbContext,RmMoldRepairRequestFault, int >, IRmMoldRepairRequestFaultRepository
	{
		public RmMoldRepairRequestFaultRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}