using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class Prdt1InfoRepository : EfCoreRepository<MesDbContext,Prdt1Info, int >, IPrdt1InfoRepository
	{
		public Prdt1InfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}