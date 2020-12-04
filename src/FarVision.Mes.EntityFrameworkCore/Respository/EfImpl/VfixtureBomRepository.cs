using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VfixtureBomRepository : EfCoreRepository<MesDbContext,VfixtureBom, int >, IVfixtureBomRepository
	{
		public VfixtureBomRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}