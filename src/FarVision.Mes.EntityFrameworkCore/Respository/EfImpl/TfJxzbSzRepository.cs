using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TfJxzbSzRepository : EfCoreRepository<MesDbContext,TfJxzbSz, int >, ITfJxzbSzRepository
	{
		public TfJxzbSzRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}