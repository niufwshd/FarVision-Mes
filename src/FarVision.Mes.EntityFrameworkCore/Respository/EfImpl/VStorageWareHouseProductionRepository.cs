using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VStorageWareHouseProductionRepository : EfCoreRepository<MesDbContext,VStorageWareHouseProduction, int >, IVStorageWareHouseProductionRepository
	{
		public VStorageWareHouseProductionRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}