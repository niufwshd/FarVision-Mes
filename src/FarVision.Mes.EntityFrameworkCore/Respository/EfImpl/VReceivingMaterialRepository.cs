using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VReceivingMaterialRepository : EfCoreRepository<MesDbContext,VReceivingMaterial, int >, IVReceivingMaterialRepository
	{
		public VReceivingMaterialRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}