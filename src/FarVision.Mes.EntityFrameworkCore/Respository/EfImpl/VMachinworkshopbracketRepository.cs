using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class VMachinworkshopbracketRepository : EfCoreRepository<MesDbContext,VMachinworkshopbracket, int >, IVMachinworkshopbracketRepository
	{
		public VMachinworkshopbracketRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}