using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TfJxzbJsRepository : EfCoreRepository<MesDbContext,TfJxzbJs, int >, ITfJxzbJsRepository
	{
		public TfJxzbJsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}