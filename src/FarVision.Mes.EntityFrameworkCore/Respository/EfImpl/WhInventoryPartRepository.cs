using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WhInventoryPartRepository : EfCoreRepository<MesDbContext,WhInventoryPart, int >, IWhInventoryPartRepository
	{
		public WhInventoryPartRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}