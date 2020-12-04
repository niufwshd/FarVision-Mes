using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VZcNoSebeiRepository : EfCoreRepository<MesDbContext,VZcNoSebei, int >, IVZcNoSebeiRepository
	{
		public VZcNoSebeiRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}