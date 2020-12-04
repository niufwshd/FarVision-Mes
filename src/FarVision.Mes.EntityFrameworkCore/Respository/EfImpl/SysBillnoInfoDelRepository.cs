using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysBillnoInfoDelRepository : EfCoreRepository<MesDbContext,SysBillnoInfoDel, int >, ISysBillnoInfoDelRepository
	{
		public SysBillnoInfoDelRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}