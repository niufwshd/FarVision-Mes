using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class StTdcodeTempRepository : EfCoreRepository<MesDbContext,StTdcodeTemp, int >, IStTdcodeTempRepository
	{
		public StTdcodeTempRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}