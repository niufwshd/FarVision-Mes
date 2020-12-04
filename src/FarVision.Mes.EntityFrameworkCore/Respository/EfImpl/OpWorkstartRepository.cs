using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class OpWorkstartRepository : EfCoreRepository<MesDbContext,OpWorkstart, int >, IOpWorkstartRepository
	{
		public OpWorkstartRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}