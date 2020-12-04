using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MmMaterielRequestRepository : EfCoreRepository<MesDbContext,MmMaterielRequest, int >, IMmMaterielRequestRepository
	{
		public MmMaterielRequestRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}