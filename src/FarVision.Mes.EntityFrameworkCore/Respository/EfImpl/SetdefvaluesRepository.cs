using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class SetdefvaluesRepository : EfCoreRepository<MesDbContext,Setdefvalues, int >, ISetdefvaluesRepository
	{
		public SetdefvaluesRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}