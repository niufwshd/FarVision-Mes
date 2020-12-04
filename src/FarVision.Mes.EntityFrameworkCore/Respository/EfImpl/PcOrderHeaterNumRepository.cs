using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcOrderHeaterNumRepository : EfCoreRepository<MesDbContext,PcOrderHeaterNum, int >, IPcOrderHeaterNumRepository
	{
		public PcOrderHeaterNumRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}