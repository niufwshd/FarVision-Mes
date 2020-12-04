using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldMaintainSpecRepository : EfCoreRepository<MesDbContext,MoldMaintainSpec, int >, IMoldMaintainSpecRepository
	{
		public MoldMaintainSpecRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}