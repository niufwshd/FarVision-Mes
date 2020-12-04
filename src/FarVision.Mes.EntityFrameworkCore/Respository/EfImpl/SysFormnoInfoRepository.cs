using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysFormnoInfoRepository : EfCoreRepository<MesDbContext,SysFormnoInfo, int >, ISysFormnoInfoRepository
	{
		public SysFormnoInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}