using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class UnacceptedProductionHandleSubResultRepository : EfCoreRepository<MesDbContext,UnacceptedProductionHandleSubResult, int >, IUnacceptedProductionHandleSubResultRepository
	{
		public UnacceptedProductionHandleSubResultRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}