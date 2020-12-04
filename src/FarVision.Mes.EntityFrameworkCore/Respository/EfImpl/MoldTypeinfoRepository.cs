using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldTypeinfoRepository : EfCoreRepository<MesDbContext,MoldTypeinfo, int >, IMoldTypeinfoRepository
	{
		public MoldTypeinfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}