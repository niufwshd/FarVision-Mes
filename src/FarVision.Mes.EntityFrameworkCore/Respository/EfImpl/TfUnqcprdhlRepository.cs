using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TfUnqcprdhlRepository : EfCoreRepository<MesDbContext,TfUnqcprdhl, int >, ITfUnqcprdhlRepository
	{
		public TfUnqcprdhlRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}