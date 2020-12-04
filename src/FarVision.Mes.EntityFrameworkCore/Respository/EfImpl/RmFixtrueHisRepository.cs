using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class RmFixtrueHisRepository : EfCoreRepository<MesDbContext,RmFixtrueHis, int >, IRmFixtrueHisRepository
	{
		public RmFixtrueHisRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}