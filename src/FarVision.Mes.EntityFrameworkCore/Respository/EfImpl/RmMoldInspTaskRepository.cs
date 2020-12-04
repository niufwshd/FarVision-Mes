using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmMoldInspTaskRepository : EfCoreRepository<MesDbContext,RmMoldInspTask, int >, IRmMoldInspTaskRepository
	{
		public RmMoldInspTaskRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}