using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SysBillnoInfoRepository : EfCoreRepository<MesDbContext,SysBillnoInfo, int >, ISysBillnoInfoRepository
	{
		public SysBillnoInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}