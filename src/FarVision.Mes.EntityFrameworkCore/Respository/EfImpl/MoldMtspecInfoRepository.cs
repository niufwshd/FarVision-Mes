using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldMtspecInfoRepository : EfCoreRepository<MesDbContext,MoldMtspecInfo, int >, IMoldMtspecInfoRepository
	{
		public MoldMtspecInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}