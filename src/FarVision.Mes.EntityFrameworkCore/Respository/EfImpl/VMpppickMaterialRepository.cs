using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VMpppickMaterialRepository : EfCoreRepository<MesDbContext,VMpppickMaterial, int >, IVMpppickMaterialRepository
	{
		public VMpppickMaterialRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}