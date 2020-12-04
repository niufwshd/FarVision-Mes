using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MsCalplanInfoRepository : EfCoreRepository<MesDbContext,MsCalplanInfo, int >, IMsCalplanInfoRepository
	{
		public MsCalplanInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}