using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class Jhtp2TempRepository : EfCoreRepository<MesDbContext,Jhtp2Temp, int >, IJhtp2TempRepository
	{
		public Jhtp2TempRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}