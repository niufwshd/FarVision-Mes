using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class PcUsrLoginRepository : EfCoreRepository<MesDbContext,PcUsrLogin, int >, IPcUsrLoginRepository
	{
		public PcUsrLoginRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}