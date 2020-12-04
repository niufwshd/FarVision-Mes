using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class EqptInfoEa2113Repository : EfCoreRepository<MesDbContext,EqptInfoEa2113, int >, IEqptInfoEa2113Repository
	{
		public EqptInfoEa2113Repository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}