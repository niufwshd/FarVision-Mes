using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MmMaterielRequestListRepository : EfCoreRepository<MesDbContext,MmMaterielRequestList, int >, IMmMaterielRequestListRepository
	{
		public MmMaterielRequestListRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}