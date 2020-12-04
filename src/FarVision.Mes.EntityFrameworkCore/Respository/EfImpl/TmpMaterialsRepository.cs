using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class TmpMaterialsRepository : EfCoreRepository<MesDbContext,TmpMaterials, int >, ITmpMaterialsRepository
	{
		public TmpMaterialsRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}