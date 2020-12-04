using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MfUnqcprdhlRepository : EfCoreRepository<MesDbContext,MfUnqcprdhl, int >, IMfUnqcprdhlRepository
	{
		public MfUnqcprdhlRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}