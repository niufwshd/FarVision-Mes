using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WmPackageTypeRelationRepository : EfCoreRepository<MesDbContext,WmPackageTypeRelation, int >, IWmPackageTypeRelationRepository
	{
		public WmPackageTypeRelationRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}