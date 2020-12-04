using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class UnacceptedProductionHandleSubRepository : EfCoreRepository<MesDbContext,UnacceptedProductionHandleSub, int >, IUnacceptedProductionHandleSubRepository
	{
		public UnacceptedProductionHandleSubRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}