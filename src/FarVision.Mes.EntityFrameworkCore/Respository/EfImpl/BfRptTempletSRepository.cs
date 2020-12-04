using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace FarVision.Mes
{
	public  class BfRptTempletSRepository : EfCoreRepository<MesDbContext,BfRptTempletS, int >, IBfRptTempletSRepository
	{
		public BfRptTempletSRepository(IDbContextProvider<MesDbContext> dbContextProvider)
		: base(dbContextProvider)
		{
		}
	}
}