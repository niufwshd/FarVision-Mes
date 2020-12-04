using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class DieChangeInfosRepository : EfCoreRepository<MesDbContext,DieChangeInfos, int >, IDieChangeInfosRepository
	{
		public DieChangeInfosRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}