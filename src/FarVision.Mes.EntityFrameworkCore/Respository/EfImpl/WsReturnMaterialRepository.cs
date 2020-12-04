using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class WsReturnMaterialRepository : EfCoreRepository<MesDbContext,WsReturnMaterial, int >, IWsReturnMaterialRepository
	{
		public WsReturnMaterialRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}