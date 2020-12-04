using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsmngStatusinfoRepository : EfCoreRepository<MesDbContext,MsmngStatusinfo, int >, IMsmngStatusinfoRepository
	{
		public MsmngStatusinfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}