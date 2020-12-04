using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StPalletcodeInfoRepository : EfCoreRepository<MesDbContext,StPalletcodeInfo, int >, IStPalletcodeInfoRepository
	{
		public StPalletcodeInfoRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}