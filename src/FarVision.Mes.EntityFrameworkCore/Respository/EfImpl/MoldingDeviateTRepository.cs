using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class MoldingDeviateTRepository : EfCoreRepository<MesDbContext,MoldingDeviateT, int >, IMoldingDeviateTRepository
	{
		public MoldingDeviateTRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}