using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StTdcodeBusiRepository : EfCoreRepository<MesDbContext,StTdcodeBusi, int >, IStTdcodeBusiRepository
	{
		public StTdcodeBusiRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}