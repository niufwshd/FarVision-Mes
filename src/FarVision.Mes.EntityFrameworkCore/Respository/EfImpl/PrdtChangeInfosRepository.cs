using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PrdtChangeInfosRepository : EfCoreRepository<MesDbContext,PrdtChangeInfos, int >, IPrdtChangeInfosRepository
	{
		public PrdtChangeInfosRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}