using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class UnacceptedProductionHandleRepository : EfCoreRepository<MesDbContext,UnacceptedProductionHandle, int >, IUnacceptedProductionHandleRepository
	{
		public UnacceptedProductionHandleRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}