using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SzbDeleteBak20181019Repository : EfCoreRepository<MesDbContext,SzbDeleteBak20181019, int >, ISzbDeleteBak20181019Repository
	{
		public SzbDeleteBak20181019Repository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}